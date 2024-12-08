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
    public partial class FormAttA1 : Form
    {
        private string connectionString = "Server=localhost;Database=tcc;Uid=root;Pwd=;";
        private int alunoId;

        public FormAttA1(int id)
        {
            InitializeComponent();
            this.alunoId = id;
        }

        private void FormAttA1_Load(object sender, EventArgs e)
        {
            CarregarSalas();
            CarregarDadosAluno();
            this.WindowState = FormWindowState.Maximized;
        }

        private void CarregarSalas()
        {
            cmbSala.Items.Clear();
            string query = "SELECT id, nomeSala FROM Sala";

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
                                cmbSala.Items.Add(new ComboboxItem
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


        private void CarregarDadosAluno()
        {
            string query = @"SELECT A.nomeAluno, A.numeroAluno, S.idSala 
                             FROM Aluno A
                             INNER JOIN Sala S ON A.idSala = S.id
                             WHERE A.id = @Id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", alunoId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNomeAluno.Text = reader["nomeAluno"].ToString();
                                txtNumeroAluno.Text = reader["numeroAluno"].ToString();

                                int salaId = Convert.ToInt32(reader["idSala"]);

                                // Seleciona a sala correspondente na ComboBox
                                foreach (ComboboxItem item in cmbSala.Items)
                                {
                                    if (item.Value == salaId)
                                    {
                                        cmbSala.SelectedItem = item;
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
                MessageBox.Show($"Erro ao carregar dados do aluno: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nomeAtualizado = txtNomeAluno.Text.Trim();
            string numeroAtualizado = txtNumeroAluno.Text.Trim();

            if (cmbSala.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma sala.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComboboxItem salaSelecionada = (ComboboxItem)cmbSala.SelectedItem;

            if (string.IsNullOrWhiteSpace(nomeAtualizado) || string.IsNullOrWhiteSpace(numeroAtualizado))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"UPDATE Aluno 
                             SET nomeAluno = @Nome, numeroAluno = @Numero, idSala = @IdSala 
                             WHERE id = @Id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", nomeAtualizado);
                        command.Parameters.AddWithValue("@Numero", numeroAtualizado);
                        command.Parameters.AddWithValue("@IdSala", salaSelecionada.Value);
                        command.Parameters.AddWithValue("@Id", alunoId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Informações atualizadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
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

        private class ComboboxItem
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

        private void txtNomeAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormAluno alunoForm = new FormAluno();
            alunoForm.Show();
            this.Close();
        }
    }
}
