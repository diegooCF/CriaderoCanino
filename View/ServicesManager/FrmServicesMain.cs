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
            dgvServices.DataSource = logicService.GetAllServices();
        }

        private void FrmServices_Load(object sender, EventArgs e)
        {
            bindServicesGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ServicesManager.FrmServicesAdd form = new ServicesManager.FrmServicesAdd();
            form.ShowDialog();
        }
    }
}
