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
    public partial class FormInseS : Form
    {
        public FormInseS()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private string connectionString = "Server=localhost;Database=tcc;Uid=root;Pwd=;";

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeSala.Text) || string.IsNullOrWhiteSpace(txtNumeroSala.Text) || cmbCursos.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomeSala = txtNomeSala.Text;
            string numeroSala = txtNumeroSala.Text;
            int idCurso = (cmbCursos.SelectedItem as ComboBoxItem).Value;

            string query = "INSERT INTO Sala (nomeSala, numeroSala, idCurso) VALUES (@nomeSala, @numeroSala, @idCurso)";

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

                        command.ExecuteNonQuery();
                        MessageBox.Show("Sala cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar a sala: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormInseS_Load(object sender, EventArgs e)
        {
            CarregarCursos();
        }

        private void CarregarCursos()
        {
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
                                // Adiciona os cursos no ComboBox.
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormSalas salasForm = new FormSalas();
            salasForm.Show();
            this.Close();
        }
    }

}
