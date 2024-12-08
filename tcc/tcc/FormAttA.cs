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
using static tcc.FormRemovA;

namespace tcc
{
    public partial class FormAttA : Form
    {
        public FormAttA()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private string connectionString = "Server=localhost;Database=tcc;Uid=root;Pwd=;";
        private int alunoIdSelecionado;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbAlunos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um aluno antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ComboboxItem selectedAluno = (ComboboxItem)cmbAlunos.SelectedItem;

            // Abrir o próximo formulário para atualizar o aluno
            FormAttA1 formAttA1 = new FormAttA1(selectedAluno.Value);
            formAttA1.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void FormAttA_Load(object sender, EventArgs e)
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
                MessageBox.Show($"Erro ao carregar salas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarAlunos(int idSala)
        {
            cmbAlunos.Items.Clear();
            string query = "SELECT id, nomeAluno FROM Aluno WHERE idSala = @IdSala";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdSala", idSala);

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
                MessageBox.Show($"Erro ao carregar alunos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FormAluno alunoForm = new FormAluno();
            alunoForm.Show();
            this.Close();
        }

        private void cmbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSalas.SelectedItem != null)
            {
                ComboboxItem selectedSala = (ComboboxItem)cmbSalas.SelectedItem;
                CarregarAlunos(selectedSala.Value);
            }
        }
       
    }
}
