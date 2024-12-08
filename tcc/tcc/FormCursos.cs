using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcc
{
    public partial class FormCursos : Form
    {
        public FormCursos()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show(); // Exibe o MenuForm
            this.Close();    // Fecha o FormAluno
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormInseC formInseC = new FormInseC();
            formInseC.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormListC formListC = new FormListC();
            formListC.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FormRemovC formRemovC = new FormRemovC();
            formRemovC.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormAttC formAttC = new FormAttC();
            formAttC.ShowDialog();
        }

        private void FormCursos_Load(object sender, EventArgs e)
        {

        }
    }
}
