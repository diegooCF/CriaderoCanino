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
    public partial class FrmZealsAdd : Form
    {

        //Form
        public FrmZealsAdd()
        {
            InitializeComponent();
        }
        private void FrmZealsAdd_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            bindFemaleCombo();
            cboFemale.SelectedValue = 0;
        }

        //Methods
        private void bindFemaleCombo()
        {
            Logic.Dog logicDog = new Logic.Dog();
            cboFemale.DataSource = logicDog.getFemales();
            cboFemale.DisplayMember = "nameReal";
            cboFemale.ValueMember = "idDogs";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cboFemale.SelectedItem == null || dtpStartZeal.Value.Date > DateTime.Today.Date)
            {
                MessageBox.Show("Uno de los valores ingresados no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
            else
            {
                Entity.Zeal objZeal = new Entity.Zeal();
                objZeal.Dogs_idDogs = Convert.ToInt32(cboFemale.SelectedValue);
                objZeal.startDate = Convert.ToDateTime(dtpStartZeal.Value);

                try
                {
                    Logic.Zeal logicZeal = new Logic.Zeal();
                    logicZeal.insert(objZeal);
                    MessageBox.Show("Celo registrado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void cboFemale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
