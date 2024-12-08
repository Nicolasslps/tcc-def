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
    public partial class FormAttS1 : Form
    {
        private string connectionString = "Server=localhost;Database=tcc;Uid=root;Pwd=;";
        private int idSala;
        public FormAttS1(int id)
        {
            InitializeComponent();
            idSala = id;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormAttS1_Load(object sender, EventArgs e)
        {
            CarregarCursos();
            CarregarDadosSala();
        }

        private void CarregarDadosSala()
        {
            string query = "SELECT nomeSala, numeroSala, idCurso FROM Sala WHERE id = @idSala";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idSala", idSala);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNomeSala.Text = reader["nomeSala"].ToString();
                                txtNumeroSala.Text = reader["numeroSala"].ToString();

                                // Selecionar o curso atual na ComboBox
                                int idCurso = Convert.ToInt32(reader["idCurso"]);
                                foreach (ComboBoxItem item in cmbCursos.Items)
                                {
                                    if (item.Value == idCurso)
                                    {
                                        cmbCursos.SelectedItem = item;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados da sala: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validação de entrada
            if (string.IsNullOrWhiteSpace(txtNomeSala.Text))
            {
                MessageBox.Show("O nome da sala é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumeroSala.Text))
            {
                MessageBox.Show("O número da sala é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCursos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um curso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obter os dados atualizados
            string nomeSala = txtNomeSala.Text.Trim();
            string numeroSala = txtNumeroSala.Text.Trim();
            int idCurso = ((ComboBoxItem)cmbCursos.SelectedItem).Value;

            // Atualizar os dados no banco de dados
            string query = "UPDATE Sala SET nomeSala = @nomeSala, numeroSala = @numeroSala, idCurso = @idCurso WHERE id = @idSala";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nomeSala", nomeSala);
                        command.Parameters.AddWithValue("@numeroSala", numeroSala);
                        command.Parameters.AddWithValue("@idCurso", idCurso);
                        command.Parameters.AddWithValue("@idSala", idSala);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sala atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma atualização foi realizada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar a sala: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarCursos()
        {
            cmbCursos.Items.Clear();

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
                MessageBox.Show($"Erro ao carregar os cursos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormSalas salasForm = new FormSalas();
            salasForm.Show();
            this.Close();
        }
    }
}
