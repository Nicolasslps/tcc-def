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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void picAluno_Click(object sender, EventArgs e)
        {
            FormAluno formAluno = new FormAluno();
            formAluno.ShowDialog();
            this.Hide();
        }

        private void picSalas_Click(object sender, EventArgs e)
        {
            FormSalas formSalas = new FormSalas();
            formSalas.ShowDialog();
            this.Hide();
        }

        private void picCursos_Click(object sender, EventArgs e)
        {
            FormCursos formCursos = new FormCursos();
            formCursos.ShowDialog();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem de confirmação antes de sair
            var resultado = MessageBox.Show(
                "Tem certeza de que deseja sair do aplicativo?",
                "Confirmação de Saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); // Fecha toda a aplicação
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
