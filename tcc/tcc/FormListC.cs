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
    public partial class FormListC : Form
    {
        private string connectionString = "Server=localhost;Database=tcc;Uid=root;Pwd=;";
        public FormListC()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormListC_Load(object sender, EventArgs e)
        {
            CarregarCursos();
        }
        private void CarregarCursos()
        {
            string query = "SELECT nomeCurso, horarioCurso FROM Curso";

            try
            {
                lstCursos.Items.Clear(); // Limpa a ListBox antes de carregar

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nomeCurso = reader["nomeCurso"].ToString();
                                string horarioCurso = reader["horarioCurso"].ToString();

                                // Adiciona os cursos na ListBox
                                lstCursos.Items.Add($"Curso: {nomeCurso} | Horário: {horarioCurso}");
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

        private void lstCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCursos cursoForm = new FormCursos();
            cursoForm.Show();
            this.Close();
        }
    }
}
