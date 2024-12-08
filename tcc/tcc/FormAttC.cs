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
using static tcc.FormRemovC;

namespace tcc
{
    public partial class FormAttC : Form
    {
        public FormAttC()
        {
            InitializeComponent();
        }

        private string connectionString = "Server=localhost;Database=tcc;Uid=root;Pwd=;";

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbCursos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um aluno para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComboboxItem selectedItem = (ComboboxItem)cmbCursos.SelectedItem;
            int cursoId = selectedItem.Value;

            FormAttC1 formAttC1 = new FormAttC1(cursoId);
            formAttC1.Show();
            this.Hide();
        }

        private void FormAttC_Load(object sender, EventArgs e)
        {
            CarregarCursos();
            this.WindowState = FormWindowState.Maximized;
        }

        private void CarregarCursos()
        {
            string query = "SELECT id, nomeCurso FROM Curso";

            try
            {
                cmbCursos.Items.Clear();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["id"]);
                                string nomeAluno = reader["nomeCurso"].ToString();

                                cmbCursos.Items.Add(new ComboboxItem { Text = nomeAluno, Value = id });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os Cursos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormCursos cursosForm = new FormCursos();
            cursosForm.Show();
            this.Close();
        }
    }
}
