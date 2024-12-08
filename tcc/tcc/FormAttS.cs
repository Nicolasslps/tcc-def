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
using static tcc.FormRemovS;

namespace tcc
{
    public partial class FormAttS : Form
    {
        public FormAttS()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private string connectionString = "Server=localhost;Database=tcc;Uid=root;Pwd=;";
        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica se uma sala foi selecionada
            if (cmbSalas.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma sala para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Passa o ID da sala selecionada para o próximo formulário (FormAttS1)
            ComboboxItem selectedSala = (ComboboxItem)cmbSalas.SelectedItem;
            int idSala = selectedSala.Value;

            FormAttS1 formAttS1 = new FormAttS1(idSala);
            formAttS1.Show();
            this.Close();
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

        private void FormAttS_Load(object sender, EventArgs e)
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
                MessageBox.Show($"Erro ao carregar os cursos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CarregarSalas(int idCurso)
        {
            cmbSalas.Items.Clear();

            string query = "SELECT id, nomeSala FROM Sala WHERE idCurso = @idCurso";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idCurso", idCurso);

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

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se há um curso selecionado antes de carregar as salas
            if (cmbCurso.SelectedItem is ComboboxItem selectedCurso)
            {
                int idCurso = selectedCurso.Value;
                CarregarSalas(idCurso);
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
