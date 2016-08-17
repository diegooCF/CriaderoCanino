using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.ServicesManager
{
    public partial class FrmServicesAdd : Form
    {
        private void bindCombos()
        {
            Logic.Dog logicDog = new Logic.Dog();
            DataTable dataTable = new DataTable();
            //Female combo
            dataTable = logicDog.getFemales();
            foreach (DataRow row in dataTable.Rows)
            {
                cboFemale.Items.Add(row["nameReal"].ToString());
            }
            //Male combo
            dataTable = logicDog.getMales();
            foreach (DataRow row in dataTable.Rows)
            {
                cboMale.Items.Add(row["nameReal"].ToString());
            }
        }
        public FrmServicesAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmServicesAdd_Load(object sender, EventArgs e)
        {
            bindCombos();
        }
    }
}
