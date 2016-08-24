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
        //Required Tables
        Logic.Dog logicFemaleDog = new Logic.Dog();
        DataTable dataFemaleTable = new DataTable();

        Logic.Dog logicMaleDog = new Logic.Dog();
        DataTable dataMaleTable = new DataTable();

        Logic.Zeal logicZeal = new Logic.Zeal();
        DataTable dataZealTable = new DataTable();
        //Entity fields
        protected int idMale = 0;
        protected int idFemale = 0;
        DateTime birthStart;
        DateTime birthEnd;
        DateTime startDogZeal;

        protected void bindFemaleCombo()
        {
            dataFemaleTable = logicFemaleDog.getFemales();
            foreach (DataRow row in dataFemaleTable.Rows)
            {
                cboFemale.Items.Add(row["nameReal"].ToString());
            }
        }
        protected void bindZealCombo()
        {
            cboZeal.Items.Clear();
            string selectedFemale = cboFemale.SelectedItem.ToString();
            dataZealTable = logicZeal.getZealFrom(logicFemaleDog.getIdByRealName(selectedFemale));
            foreach (DataRow row in dataZealTable.Rows)
            {
                cboZeal.Items.Add(row["startDate"]);
            }
        }
        protected void bindMaleCombo()
        {
            dataMaleTable = logicMaleDog.getMales();
            foreach (DataRow row in dataMaleTable.Rows)
            {
                cboMale.Items.Add(row["nameReal"].ToString());
            }
        }
        protected void bindCombos()
        {
            bindFemaleCombo();
            bindMaleCombo();
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
        }
        private void cboFemale_SelectedIndexChanged(object sender, EventArgs e)
        {
            idFemale = Convert.ToInt32(dataFemaleTable.Rows[0]["idDogs"].ToString());
            bindZealCombo();
        }
        private void cboMale_SelectedIndexChanged(object sender, EventArgs e)
        {
            idMale = Convert.ToInt32(dataMaleTable.Rows[0]["idDogs"].ToString());
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
                birthStart = dtpMinBirth.Value;
                birthEnd = dtpMaxBirth.Value;
                startDogZeal = Convert.ToDateTime(cboZeal.Text);
                Entity.Service entityService = new Entity.Service(idMale, idFemale, birthStart.Date, birthEnd.Date, idFemale, startDogZeal.Date);
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
