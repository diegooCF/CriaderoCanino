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
        Logic.Dog logicFemaleDog = new Logic.Dog();
        Logic.Dog logicMaleDog = new Logic.Dog();
        Logic.Zeal logicZeal = new Logic.Zeal();

        //Entity fields
        protected int idMale = 0;
        protected int idFemale = 0;
        DateTime Zeal_startDate;

        protected void bindZealCombo()
        {
            cboZeal.DataSource = logicZeal.getZealFrom(Convert.ToInt32(cboFemale.SelectedValue));
            cboZeal.DisplayMember = "startDate";
        }
        protected void bindCombos()
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
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            bindCombos();
            cboMale.SelectedValue = 0;
            cboFemale.SelectedValue = 0;
        }
        private void cboFemale_SelectedIndexChanged(object sender, EventArgs e)
        {
            idFemale = Convert.ToInt32(cboFemale.SelectedValue);
            bindZealCombo();
        }
        private void cboMale_SelectedIndexChanged(object sender, EventArgs e)
        {
            idMale = Convert.ToInt32(cboMale.SelectedValue);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cboMale.SelectedItem == null || cboFemale.SelectedItem == null || cboZeal.SelectedItem == null)
            {
                MessageBox.Show("Uno de los campos requeridos es invalido", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Asign selected Dates
                Zeal_startDate = Convert.ToDateTime(cboZeal.Text);
                Entity.Service entityService = new Entity.Service(idMale, idFemale, Zeal_startDate.Date);
                try
                {
                    Logic.Service logicService = new Logic.Service();
                    logicService.insert(entityService);
                    MessageBox.Show("Servicio agregado correctamente", "Registro correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error en registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
