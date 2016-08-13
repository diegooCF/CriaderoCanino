using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmMain : Form
    {
        private int childFormNumber = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void especieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create an entity and a logic objects to use his methods
            Entity.Specie entitySpecie = new Entity.Specie("Caniche");
            Logic.Specie logicSpecie = new Logic.Specie();
            try
            {
                logicSpecie.insert(entitySpecie);
                MessageBox.Show(this, "Especie " + entitySpecie.Description +" agregada correctamente", "Registro agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Se ha producido un error en el acceso a datos. Detalles: " + ex.Message, "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void especiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CUD.FrmCreateSpecie form = new CUD.FrmCreateSpecie();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }
    }
}
