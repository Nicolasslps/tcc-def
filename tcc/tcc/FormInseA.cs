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
    public partial class FormInseA : Form
    {
        public FormInseA()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private string connectionString = "Server=localhost;Database=tcc;Uid=root;Pwd=;";
        private void CarregarCursos()
        {
            cmbCursos.Items.Clear(); // Limpar a ComboBox antes de carregar os cursos

            string query = "SELECT id, nomeCurso FROM Curso";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbCursos.Items.Add(new ComboBoxItem
                                {
                                    Text = reader["nomeCurso"].ToString(),
                                    Value = Convert.ToInt32(reader["id"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar cursos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarSalas()
        {
            string query = "SELECT id, nomeSala FROM Sala";

            try
            {
                cmbSalas.Items.Clear();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbSalas.Items.Add(new ComboBoxItem
                                {
                                    Text = reader["nomeSala"].ToString(),
                                    Value = Convert.ToInt32(reader["id"])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar salas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome do aluno é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                MessageBox.Show("O número do aluno é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCursos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um curso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSalas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma sala.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomeAluno = txtNome.Text.Trim();
            string numeroAluno = txtNumero.Text.Trim();
            int idCurso = ((ComboBoxItem)cmbCursos.SelectedItem).Value;
            int idSala = ((ComboBoxItem)cmbSalas.SelectedItem).Value;

            string query = "INSERT INTO Aluno (nomeAluno, numeroAluno, idCurso, idSala) VALUES (@nomeAluno, @numeroAluno, @idCurso, @idSala)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nomeAluno", nomeAluno);
                        command.Parameters.AddWithValue("@numeroAluno", numeroAluno);
                        command.Parameters.AddWithValue("@idCurso", idCurso);
                        command.Parameters.AddWithValue("@idSala", idSala);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNome.Clear();
                            txtNumero.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi inserido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao inserir o aluno: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GerarNumeroAluno()
        {
            string query = "SELECT IFNULL(MAX(numeroAluno), 0) + 1 AS proximoNumero FROM Aluno";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtNumero.Clear();
            cmbCursos.SelectedIndex = -1;
        }

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormInseA_Load(object sender, EventArgs e)
        {
            CarregarCursos();
            CarregarSalas();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormAluno alunoForm = new FormAluno();
            alunoForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
