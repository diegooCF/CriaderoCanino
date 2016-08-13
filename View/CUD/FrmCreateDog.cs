using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.CUD
{
    public partial class FrmCreateDog : Form
    {
        public FrmCreateDog()
        {
            InitializeComponent();
        }

        private void BindSpecies()
        {
            Logic.Specie logicSpecie = new Logic.Specie();
            DataTable dataTable = new DataTable();
            dataTable = logicSpecie.getSpecies();

            foreach (DataRow row in dataTable.Rows)
            {
                //int idSpecie = Convert.ToInt32(row["idSpecie"].ToString());
                cboSpecie.Items.Add(row["description"].ToString());
            }
        }
        private void BindColors()
        {
            Logic.Color logicColor = new Logic.Color();
            DataTable dataTable = new DataTable();
            dataTable = logicColor.getColors();

            foreach (DataRow row in dataTable.Rows)
            {
                cboColor.Items.Add(row["description"].ToString());
            }
        }

        private void FrmCreateDog_Load(object sender, EventArgs e)
        {
            //Load setup
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            //We bind both Combos
            BindSpecies();
            BindColors();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private int getId(DataTable dataTable, ComboBox cbo)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["description"].ToString() == cbo.SelectedItem.ToString())
                {
                    return Convert.ToInt32(row[0].ToString());
                }
            }
            return 0;
        }
        private void clearFields()
        {
            txtRealName.Clear();
            txtFormalName.Clear();
            cboSpecie.SelectedIndex = 0;
            cboColor.SelectedIndex= 0;
            cboGender.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {           
            string realName = txtRealName.Text;
            string formalName = txtFormalName.Text;
            DateTime birthDate = Convert.ToDateTime(dtpBirthDate.Text);
            string gender = cboGender.SelectedItem.ToString();
            //Required fields for foreigns keys
            Logic.Specie logicSpecie = new Logic.Specie();
            Logic.Color logicColor = new Logic.Color();
            DataTable dataTable = new DataTable();
            int Species_idSpecie;
            int Colors_idColor;

            //Receipts the ID of Selected item in the Combobox (SPECIE)
            dataTable = logicSpecie.getSpecies();
            Species_idSpecie = getId(dataTable, cboSpecie);

            //Receipts the ID of Selected item in the Combobox (COLOR)
            dataTable = logicColor.getColors();
            Colors_idColor = getId(dataTable, cboColor);
            try
            {
                //Insert Dog
                Entity.Dog entityDog = new Entity.Dog(realName, formalName, birthDate, gender, Species_idSpecie, Colors_idColor);
                Logic.Dog logicDog = new Logic.Dog();
                logicDog.insert(entityDog);

                MessageBox.Show("Canino agregado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRealName.Focus();
            }
        }
    }
}
