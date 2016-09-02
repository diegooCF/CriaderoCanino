using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.ZealsManager
{
    public partial class FrmZealsModify : Form
    {
        //Logical resources
        private Logic.Dog logicFemaleDog = new Logic.Dog();
        private DataGridViewRow selectedRow;

        //Entity fields
        int Dogs_idDogs = 0;
        DateTime startDate; 

        //Form
        public FrmZealsModify(DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.selectedRow = selectedRow;
        }
        private void FrmZealsModify_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            cboFemale.SelectedValue = 0;
            bindCurrents();
            bindFemaleCombo();
        }

        //Methods
        private void bindCurrents()
        {
            lblCurrentFemale.Text = selectedRow.Cells["Hembra"].Value.ToString();
            lblCurrentStartDate.Text = selectedRow.Cells["Inicio de Celo"].Value.ToString();
        }
        private void bindFemaleCombo()
        {
            //Bind female combo
            cboFemale.DataSource = logicFemaleDog.getFemales();
            cboFemale.DisplayMember = "nameReal";
            cboFemale.ValueMember = "idDogs";
            this.cboFemale.SelectedIndexChanged += new System.EventHandler(this.cboFemale_SelectedIndexChanged);
        }

        //Buttons & Events
        private void cboFemale_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dogs_idDogs = Convert.ToInt32(cboFemale.SelectedValue);
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            if(cboFemale.SelectedItem == null || dtpStartZeal.Value.Date > DateTime.Today.Date)
            {
                MessageBox.Show("Uno de los campos requeridos es invalido", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //TODO Arreglar modificar servicios, añadir, uniques, pk, fk, en zeal y services
                Entity.Zeal objZeal = new Entity.Zeal();
                objZeal.Dogs_idDogs = Dogs_idDogs;
                objZeal.startDate = startDate;
                try
                {
                    Logic.Zeal logicZeal = new Logic.Zeal();
                    if (MessageBox.Show("Desea aceptar las modificaciones?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        logicZeal.update(objZeal);
                        MessageBox.Show("Celo modificado correctamente", "Registro correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dtpStartZeal_ValueChanged(object sender, EventArgs e)
        {
            startDate = Convert.ToDateTime(dtpStartZeal.Value);
        }
    }
}
