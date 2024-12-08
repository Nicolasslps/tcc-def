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
    public partial class FormAluno : Form
    {
        public FormAluno()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FormAttA formAttA = new FormAttA();
            formAttA.ShowDialog();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Retorna ao MenuForm
            MenuForm menuForm = new MenuForm();
            menuForm.Show(); // Exibe o MenuForm
            this.Close();    // Fecha o FormAluno
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormInseA formInseA = new FormInseA();
            formInseA.ShowDialog();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormListA formListA = new FormListA();
            formListA.ShowDialog();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FormRemovA formRemovA = new FormRemovA();
            formRemovA.ShowDialog();
            this.Hide();
        }

        private void FormAluno_Load(object sender, EventArgs e)
        {

        }
    }
}
