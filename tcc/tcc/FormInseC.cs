using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tcc
{
    public partial class FormInseC : Form
    {
        public FormInseC()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Capturar os dados inseridos
                string nome = txtnomeCurso.Text.Trim();
                string numero = txtHorario.Text.Trim();

                // Validação simples
                if (string.IsNullOrWhiteSpace(nome))
                {
                    MessageBox.Show("O campo Nome do curso é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(numero))
                {
                    MessageBox.Show("O campo Horario do curso é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // String de conexão com o banco de dados
                string connectionString = "Server=localhost;Database=tcc;Uid=root;Pwd=;";

                // Comando SQL para inserir os dados
                string query = "INSERT INTO Curso (nomeCurso, horarioCurso) VALUES (@nomeCurso, @horarioCurso)";

                try
                {
                    // Conectando ao banco de dados
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Preparando o comando SQL
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            // Adicionando os parâmetros
                            command.Parameters.AddWithValue("@nomeCurso", nome);
                            command.Parameters.AddWithValue("@horarioCurso", numero);

                            // Executando o comando
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Curso cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtnomeCurso.Clear();
                                txtHorario.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Nenhum registro foi inserido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormInseC_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormCursos cursosForm = new FormCursos();
            cursosForm.Show();
            this.Close();
        }
    }

}
