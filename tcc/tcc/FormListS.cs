using System;
using System.Collections.Generic;
using System;
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
    public partial class FormListS : Form
    {
        private string connectionString = "Server=localhost;Database=tcc;Uid=root;Pwd=;";

        public FormListS()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormListS_Load(object sender, EventArgs e)
        {
            CarregarSalas();
        }

        private void CarregarSalas()
        {
            // Consulta para buscar os dados das salas e do curso
            string query = @"
                SELECT Sala.nomeSala, Sala.numeroSala, Curso.nomeCurso
                FROM Sala
                INNER JOIN Curso ON Sala.idCurso = Curso.id";

            try
            {
                lstSalas.Items.Clear(); // Limpa a ListBox antes de carregar

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nomeSala = reader["nomeSala"].ToString();
                                string numeroSala = reader["numeroSala"].ToString();
                                string nomeCurso = reader["nomeCurso"].ToString();

                                // Adiciona as informações na ListBox
                                lstSalas.Items.Add($"Sala: {nomeSala} | Número da sala: {numeroSala} | Curso: {nomeCurso}");
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
            FormSalas salaForm = new FormSalas();
            salaForm.Show();
            this.Close();
        }

        private void lstSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Código para manipular a seleção de um item da ListBox, se necessário
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

