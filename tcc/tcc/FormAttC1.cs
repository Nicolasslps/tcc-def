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
    public partial class FormAttC1 : Form
    {
        private string connectionString = "Server=localhost;Database=tcc;Uid=root;Pwd=;";
        private int cursoId;
        public FormAttC1(int id)
        {
            InitializeComponent();
            cursoId = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeAtualizado = txtNomeCurso.Text.Trim();
            string horarioAtualizado = txtHorarioCurso.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomeAtualizado) || string.IsNullOrWhiteSpace(horarioAtualizado))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "UPDATE Aluno SET nomeCurso = @Nome, horarioCurso = @Horario WHERE id = @Id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", nomeAtualizado);
                        command.Parameters.AddWithValue("@Horario", horarioAtualizado);
                        command.Parameters.AddWithValue("@Id", cursoId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Informações atualizadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma alteração foi feita.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar as informações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAttC1_Load(object sender, EventArgs e)
        {
            CarregarDadosCurso();
            this.WindowState = FormWindowState.Maximized;
        }

        private void CarregarDadosCurso()
        {
            string query = "SELECT nomeCurso, horarioCurso FROM Curso WHERE id = @Id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", cursoId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNomeCurso.Text = reader["nomeCurso"].ToString();
                                txtHorarioCurso.Text = reader["horarioCurso"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormCursos cursosForm = new FormCursos();
            cursosForm.Show();
            this.Close();
        }
    }
}
