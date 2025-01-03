﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using tcc.dados;

public class AlunoRepository
{
    private string connectionString;

    public AlunoRepository()
    {
        connectionString = Bdconfig.GetConnectionString();
    }

    // Create
    public void InserirAluno(Aluno aluno)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            var query = "INSERT INTO aluno (nome, numero) VALUES (@nome, @numero)";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nome", aluno.nomeAluno);
                command.Parameters.AddWithValue("@numero", aluno.numeroAluno);
                command.ExecuteNonQuery();
            }
        }
    }

    // Read
    public List<Aluno> ObterTodosAlunos()
    {
        var alunos = new List<Aluno>();
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            var query = "SELECT id, numero, nome FROM aluno";
            using (var command = new MySqlCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        alunos.Add(new Aluno
                        {
                            id = reader.GetInt32("id"),
                            nomeAluno = reader.GetString("nome"),
                            numeroAluno = reader.GetInt32("numero")
                        });
                    }
                }
            }
        }
        return alunos;
    }

    // Update
    public void AtualizarAluno(Aluno aluno)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            var query = "UPDATE aluno SET nome = @nome WHERE numero = @numero";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nome", aluno.nomeAluno);
                command.Parameters.AddWithValue("@numero", aluno.numeroAluno);
                command.ExecuteNonQuery();
            }
        }
    }

    // Delete
    public void ExcluirAluno(int numero)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            var query = "DELETE FROM aluno WHERE numero = @numero";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@numero", numero);
                command.ExecuteNonQuery();
            }
        }
    }
}

