using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Management
{
    public partial class FrmServices : Form
    {
        public FrmServices()
        {
            InitializeComponent();
        }

        private void bindServicesGrid()
        {
            Logic.Service logicService = new Logic.Service();
            dgvServices.DataSource = logicService.getAllServices();
        }

        private void FrmServices_Load(object sender, EventArgs e)
        {
            bindServicesGrid();
        }
        private void refreshDataGridView()
        {
            Logic.Service logicService = new Logic.Service();
            dgvServices.DataSource = null;
            dgvServices.DataSource = logicService.getAllServices();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ServicesManager.FrmServicesAdd form = new ServicesManager.FrmServicesAdd();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                refreshDataGridView();
            }           
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                ServicesManager.FrmServicesModify form = new ServicesManager.FrmServicesModify(dgvServices.CurrentRow);
                form.ShowDialog();
                refreshDataGridView();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna celda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
