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
    public partial class FrmServicesDelete : Form
    {
        public FrmServicesDelete()
        {
            InitializeComponent();
        }
        private void bindCombo()
        {
            Logic.Service logicService = new Logic.Service();
            cboService.DataSource = logicService.getAllServicesCompositeData();
            cboService.DisplayMember = "Servicio";
            cboService.ValueMember = "ID";
            this.cboService.SelectedIndexChanged += new System.EventHandler(this.cboService_SelectedIndexChanged);
        }
        private void FrmServicesDelete_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            bindCombo();
            cboService.SelectedValue = 0;
            txtFemale.Clear();
            txtMale.Clear();
            txtZeal.Clear();
            }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            Logic.Service logicService = new Logic.Service();
            DataTable dataTable = new DataTable();
            dataTable = logicService.getAllServicesCompositeData();
            try
            {
                txtFemale.Text = dataTable.Rows[0]["Hembra"].ToString();
                txtZeal.Text = dataTable.Rows[0]["Inicio de Celo"].ToString();
                txtMale.Text = dataTable.Rows[0]["Macho"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cboService == null)
            {
                MessageBox.Show("Uno de los campos requeridos es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Logic.Service logicService = new Logic.Service();
                    if (MessageBox.Show("Esta seguro que desea eliminar el servicio? Será irrecuperable", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        logicService.delete(Convert.ToInt32(cboService.SelectedValue));
                        MessageBox.Show("Servicio modificado correctamente", "Registro correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
