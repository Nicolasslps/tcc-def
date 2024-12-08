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
using Org.BouncyCastle.Crypto;

namespace tcc
{
    public partial class FormRemovA : Form
    {
        public FormRemovA()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private string connectionString = "Server=localhost;Database=tcc;Uid=root;Pwd=;";
        private void Form3_Load(object sender, EventArgs e)
        {
            CarregarSalas();
        }

       

        private void CarregarSalas()
        {
            cmbSalas.Items.Clear();

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
                                cmbSalas.Items.Add(new ComboboxItem
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
                MessageBox.Show($"Erro ao carregar as salas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarAlunos(int idSala)
        {
            cmbAlunos.Items.Clear();

            string query = "SELECT id, nomeAluno FROM Aluno WHERE idSala = @idSala";

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
                            while (reader.Read())
                            {
                                cmbAlunos.Items.Add(new ComboboxItem
                                {
                                    Text = reader["nomeAluno"].ToString(),
                                    Value = Convert.ToInt32(reader["id"])
                                });
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


        public class ComboboxItem
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbAlunos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um aluno para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComboboxItem selectedAluno = (ComboboxItem)cmbAlunos.SelectedItem;
            int alunoId = selectedAluno.Value;

            string query = "DELETE FROM Aluno WHERE id = @id";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", alunoId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Aluno removido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmbAlunos.Items.Clear(); // Atualizar lista de alunos
                        }
                        else
                        {
                            MessageBox.Show("Erro ao remover o aluno.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover o aluno: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormAluno alunoForm = new FormAluno();
            alunoForm.Show();
            this.Close();
        }

        private void cmbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

       

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void cmbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbSalas.SelectedItem is ComboboxItem selectedSala)
            {
                int idSala = selectedSala.Value;
                CarregarAlunos(idSala);
            }
        }
    }
}
