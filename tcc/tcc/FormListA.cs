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
    public partial class FormListA : Form
    {
        public FormListA()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAluno alunoForm = new FormAluno();
            alunoForm.Show();
            this.Close();
        }

        private void lstAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private string connectionString = "Server=localhost;Database=tcc;Uid=root;Pwd=;";

        private void FormListA_Load(object sender, EventArgs e)
        {
            CarregarAlunos();
        }

        private void CarregarAlunos()
        {
            lstAlunos.Items.Clear(); // Limpar a ListBox antes de carregar os alunos

            // Consulta SQL para buscar os alunos, incluindo o nome do curso
            string query = @"SELECT 
                                Aluno.nomeAluno, 
                                Aluno.numeroAluno, 
                                Curso.nomeCurso,
                                Sala.nomeSala
                             FROM 
                                Aluno
                             INNER JOIN 
                                Curso ON Aluno.idCurso = Curso.id
                             INNER JOIN
                                Sala ON Aluno.idSala = Sala.id";

            try
            {
                lstAlunos.Items.Clear(); // Limpa a ListBox antes de carregar os dados

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nomeAluno = reader["nomeAluno"].ToString();
                                string numeroAluno = reader["numeroAluno"].ToString();
                                string nomeCurso = reader["nomeCurso"].ToString();
                                string nomeSala = reader["nomeSala"].ToString();

                                // Adiciona os dados do aluno na ListBox
                                lstAlunos.Items.Add($"Aluno: {nomeAluno} | Número: {numeroAluno} | Curso: {nomeCurso} | Sala: {nomeSala}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os alunos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
