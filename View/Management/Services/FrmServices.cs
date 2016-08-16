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

        private void bindDataGridView()
        {
            Logic.Service logicService = new Logic.Service();
            dgvServices.DataSource = logicService.GetAllServices();
        }
        private void FrmManagement_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            bindDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
