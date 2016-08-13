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
    public partial class FrmCreateColor : Form
    {
        public FrmCreateColor()
        {
            InitializeComponent();
        }

        private void getColors()
        {
            Logic.Color objColor = new Logic.Color();
            DataTable dataTable = objColor.getColors();
            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dataTable.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lvColors.Items.Add(item);
            }
        }
        private void FrmCreateColor_Load(object sender, EventArgs e)
        {
            //Load setup
            MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            txtDescription.Focus();
            //Bind the listview at start
            getColors();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert new Color to DB
                Logic.Color logicSpecie = new Logic.Color();
                Entity.Color entitySpecie = new Entity.Color(txtDescription.Text);
                logicSpecie.insert(entitySpecie);

                //Message and reload listView
                MessageBox.Show("Especie agregada correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lvColors.Items.Clear();
                txtDescription.Clear();
                txtDescription.Focus();
                getColors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
            }
        }
    }
}
