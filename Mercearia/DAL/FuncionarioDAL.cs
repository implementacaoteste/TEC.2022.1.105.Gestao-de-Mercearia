using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FuncionarioDAL
    {
        public void Inserir(Funcionario _funcionario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Funcionario(Nome, Telefone, Ativo, Profissao, Salario) 
                                    VALUES(@Nome, @Telefone, @Ativo, @Profissao, @Salario)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _funcionario.Nome);
                cmd.Parameters.AddWithValue("@Telefone", _funcionario.Telefone);
                cmd.Parameters.AddWithValue("@Ativo", _funcionario.Ativo);
                cmd.Parameters.AddWithValue("@Profissao", _funcionario.Profissao);
                cmd.Parameters.AddWithValue("@Salario", _funcionario.Salario);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um funcionario no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Funcionario _funcionario)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Funcionario SET
                                        Nome = @Nome, 
                                        Telefone = @Telefone, 
                                        Ativo = @Ativo, 
                                        Profissao = @Profissao, 
                                        Salario = @Salario
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _funcionario.Id);
                cmd.Parameters.AddWithValue("@Nome", _funcionario.Nome);
                cmd.Parameters.AddWithValue("@Telefone", _funcionario.Telefone);
                cmd.Parameters.AddWithValue("@Ativo", _funcionario.Ativo);
                cmd.Parameters.AddWithValue("@Profissao", _funcionario.Profissao);
                cmd.Parameters.AddWithValue("@Salario", _funcionario.Salario);


                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar funcionario no banco de dados", ex) { Data = { { "Id", 1004 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Funcionario WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir Funcionario no banco de dados.", ex) { Data = { { "Id", 1005 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Funcionario> BuscarTodos()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Funcionario funcionario = new Funcionario();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Telefone, Ativo, Profissao, Salario FROM Funcionario";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        funcionario = new Funcionario();
                        funcionario.Id = Convert.ToInt32(rd["Id"]);
                        funcionario.Nome = rd["Nome"].ToString();
                        funcionario.Telefone = rd["Telefone"].ToString();
                        funcionario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        funcionario.Profissao = rd["Profissao"].ToString();
                        funcionario.Salario = (double)rd["Salario"];

                        funcionarios.Add(funcionario);

                    }
                    return funcionarios;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os funcionarios no banco de dados", ex);

            }
            finally
            {
                cn.Close();
            }
        }

        public List<Funcionario> BuscarPorNome(string _nome)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Funcionario funcionario = new Funcionario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Telefone, Ativo, Profissao, Salario FROM Funcionario WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        funcionario = new Funcionario();
                        funcionario.Id = Convert.ToInt32(rd["Id"]);
                        funcionario.Nome = rd["Nome"].ToString();
                        funcionario.Telefone = rd["Telefone"].ToString();
                        funcionario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        funcionario.Profissao = rd["Profissao"].ToString();
                        funcionario.Salario = (double)rd["Salario"];
                        funcionarios.Add(funcionario);
                    }
                }
                return funcionarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por nome no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }

        }

        public Funcionario BuscarPorId(int _id)
        {
            //Funcionario funcionario = new Funcionario();
            Funcionario funcionario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Telefone, Ativo, Profissao, Salario FROM Funcionario WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    funcionario = new Funcionario();
                    if (rd.Read()) 
                    { 
                        funcionario.Id = Convert.ToInt32(rd["Id"]);
                        funcionario.Nome = rd["Nome"].ToString();
                        funcionario.Telefone = rd["Telefone"].ToString();
                        funcionario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        funcionario.Profissao = rd["Profissao"].ToString();
                        funcionario.Salario = Convert.ToDouble(rd["Salario"]);
                    }
                }
                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por id no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
