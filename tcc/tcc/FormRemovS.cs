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
    public partial class FormRemovS : Form
    {
        public FormRemovS()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private string connectionString = "Server=localhost;Database=tcc;Uid=root;Pwd=;";

        private void FormRemovS_Load(object sender, EventArgs e)
        {
            CarregarCursos();
        }

        private void CarregarCursos()
        {
            cmbCurso.Items.Clear();
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
                                cmbCurso.Items.Add(new ComboboxItem
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

        private void CarregarSalas(int idCurso)
        {
            cmbSalas.Items.Clear();
            string query = "SELECT id, nomeSala FROM Sala WHERE idCurso = @IdCurso";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCurso", idCurso);

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
                MessageBox.Show($"Erro ao carregar salas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbSalas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma sala para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComboboxItem salaSelecionada = (ComboboxItem)cmbSalas.SelectedItem;
            int idSala = salaSelecionada.Value;

            string query = "DELETE FROM Sala WHERE idSala = @IdSala";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdSala", idSala);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sala removida com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmbSalas.Items.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível remover a sala.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover sala: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurso.SelectedItem is ComboboxItem cursoSelecionado)
            {
                int idCurso = cursoSelecionado.Value;
                CarregarSalas(idCurso);
            }
        }

        private void label2_Click(object sender, EventArgs e)
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
