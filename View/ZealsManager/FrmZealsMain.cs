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
    public partial class FrmZealsMain : Form
    {
        //Form
        public FrmZealsMain()
        {
            InitializeComponent();
        }
        private void FrmZealsMain_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            bindZealsGrid();
        }

        //Methods
        private void refreshDataGridView()
        {
            Logic.Zeal logicZeal = new Logic.Zeal();
            dgvZeals.DataSource = null;
            dgvZeals.DataSource = logicZeal.getAllActiveZeals();
        }
        private void bindZealsGrid()
        {
            Logic.Zeal logicZeal = new Logic.Zeal();
            dgvZeals.DataSource = logicZeal.getAllActiveZeals();
        }

        //Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmZealsAdd form = new FrmZealsAdd();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                refreshDataGridView();
            }
        }
    }
}
