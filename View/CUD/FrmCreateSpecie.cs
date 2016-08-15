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
    public partial class FrmCreateSpecie : Form
    {
        public FrmCreateSpecie()
        {
            InitializeComponent();
        }

        private void tryConnectionToDB()
        {
            
        }
        private void getSpecies()
        {
            try
            {
                Logic.Specie objSpecie = new Logic.Specie();
                DataTable dataTable = objSpecie.getSpecies();
                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dataTable.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lvSpecies.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmCreateSpecie_Load(object sender, EventArgs e)
        {
            //Load setup
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            txtDescription.Focus();
            //Bind the listview at start
            getSpecies();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert new Specie to DB
                Logic.Specie logicSpecie = new Logic.Specie();
                Entity.Specie entitySpecie = new Entity.Specie(txtDescription.Text);
                logicSpecie.insert(entitySpecie);

                //Message and reload listView
                MessageBox.Show("Especie agregada correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lvSpecies.Items.Clear();
                txtDescription.Clear();
                txtDescription.Focus();
                getSpecies();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error en registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
