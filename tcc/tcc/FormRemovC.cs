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
    public partial class FormRemovC : Form
    {
        public FormRemovC()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private string connectionString = "Server=localhost;Database=tcc;Uid=root;Pwd=;";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormRemovC_Load(object sender, EventArgs e)
        {
            CarregarCursos();
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
                                cmbCursos.Items.Add(new ComboboxItem
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
            if (cmbCursos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um curso para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComboboxItem cursoSelecionado = (ComboboxItem)cmbCursos.SelectedItem;
            int idCurso = cursoSelecionado.Value;

            // Confirmar a remoção
            DialogResult confirm = MessageBox.Show(
                "Tem certeza de que deseja remover este curso? Todos os alunos e salas vinculados a ele também serão removidos.",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                string query = "DELETE FROM Curso WHERE id = @IdCurso";

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@IdCurso", idCurso);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Curso removido com sucesso. Alunos e salas vinculados foram removidos.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CarregarCursos();
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível remover o curso.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao remover curso: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormCursos cursoForm = new FormCursos();
            cursoForm.Show();
            this.Close();
        }
    }
}
