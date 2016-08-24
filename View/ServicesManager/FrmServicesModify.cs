using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View.ServicesManager
{
    public partial class FrmServicesModify : FrmServicesAdd
    {
        private DateTime birthStart;
        private DateTime birthEnd;
        private DateTime startDogZeal;
        private DataGridViewSelectedRowCollection selectedRow;
        public FrmServicesModify(DataGridViewSelectedRowCollection selectedRow)
        {
            InitializeComponent();
            this.selectedRow = selectedRow;
            bindCurrentValues();
        }
        private void bindCurrentValues()
        {
            lblFemale.Text = selectedRow[0].Cells["Hembra"].Value.ToString();
            lblMale.Text = selectedRow[0].Cells["Macho"].Value.ToString();
            //TODO Show as DATE ONLY! & FIX UPDATE(not working)
            lblMinDateBirth.Text = selectedRow[0].Cells["Aprox Min Fecha Parto"].Value.ToString();
            lblDateMaxBirth.Text = selectedRow[0].Cells["Aprox Max Fecha Parto"].Value.ToString();
            lblZeal.Text = selectedRow[0].Cells["Inicio de Celo"].Value.ToString();
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cboMale.SelectedItem == null || cboFemale.SelectedItem == null || cboZeal.SelectedItem == null)
            {
                MessageBox.Show("Uno de los campos requeridos es invalido", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Asign selected Dates
                birthStart = dtpMinBirth.Value;
                birthEnd = dtpMaxBirth.Value;
                startDogZeal = Convert.ToDateTime(cboZeal.Text);
                Entity.Service entityService = new Entity.Service(idMale, idFemale, birthStart, birthEnd, idFemale, startDogZeal);
                try
                {
                    Logic.Service logicService = new Logic.Service();
                    if (MessageBox.Show("Desea aceptar los cambios?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        logicService.update(entityService);
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
