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
    public partial class FrmServicesModify : Form
    {
        //Logical resources
        private Logic.Dog logicFemaleDog = new Logic.Dog();
        private Logic.Dog logicMaleDog = new Logic.Dog();
        private Logic.Zeal logicZeal = new Logic.Zeal();
        private DataGridViewRow selectedRow;

        //Entity fields
        protected int idMale = 0;
        protected int idFemale = 0;
        DateTime Zeal_startDate;

        //Form
        public FrmServicesModify(DataGridViewRow selectedRow)
        {
            InitializeComponent();
            this.selectedRow = selectedRow;
        }
        private void FrmServicesModify_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            bindCurrents();
            bindCombos();
            cboMale.SelectedValue = 0;
            cboFemale.SelectedValue = 0;
        }

        //Methods
        private void bindCombos()
        {
            //Bind female combo
            cboFemale.DataSource = logicFemaleDog.getFemales();
            cboFemale.DisplayMember = "nameReal";
            cboFemale.ValueMember = "idDogs";
            this.cboFemale.SelectedIndexChanged += new System.EventHandler(this.cboFemale_SelectedIndexChanged);
            //Bind male combo
            cboMale.DataSource = logicMaleDog.getMales();
            cboMale.DisplayMember = "nameReal";
            cboMale.ValueMember = "idDogs";
            this.cboMale.SelectedIndexChanged += new System.EventHandler(this.cboMale_SelectedIndexChanged);
        }
        private void bindZealCombo()
        {
            cboZeal.DataSource = logicZeal.getZealFrom(Convert.ToInt32(cboFemale.SelectedValue));
            cboZeal.DisplayMember = "startDate";
        }
        private void bindCurrents()
        {
            lblCurrentFemale.Text = selectedRow.Cells["Hembra"].Value.ToString();
            lblCurrentZeal.Text = selectedRow.Cells["Inicio de Celo"].Value.ToString();
            lblCurrentMale.Text = selectedRow.Cells["Macho"].Value.ToString();
        }

        //Buttons & Events
        private void cboFemale_SelectedIndexChanged(object sender, EventArgs e)
        {
            idFemale = Convert.ToInt32(cboFemale.SelectedValue);
            bindZealCombo();
        }
        private void cboMale_SelectedIndexChanged(object sender, EventArgs e)
        {
            idMale = Convert.ToInt32(cboMale.SelectedValue);
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (cboMale.SelectedItem == null || cboFemale.SelectedItem == null || cboZeal.SelectedItem == null)
            {
                MessageBox.Show("Uno de los campos requeridos es invalido", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Zeal_startDate = Convert.ToDateTime(cboZeal.Text);
                Entity.Service entityService = new Entity.Service(idMale, idFemale, Zeal_startDate.Date);
                try
                {
                    Logic.Service logicService = new Logic.Service();
                    if (MessageBox.Show("Desea aceptar las modificaciones?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
