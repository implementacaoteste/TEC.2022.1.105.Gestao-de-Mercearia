using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FornecedorDAL
    {
        public void Inserir(Fornecedor _fornecedor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Fornecedor(Nome, Email, Telefone, Endereco, CEP) 
                                    VALUES(@Nome, @Email, @Telefone, @Endereco, @CEP)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _fornecedor.Nome);
                cmd.Parameters.AddWithValue("@Email", _fornecedor.Email);
                cmd.Parameters.AddWithValue("@Telefone", _fornecedor.Fone);
                cmd.Parameters.AddWithValue("@Endereco", _fornecedor.Endereco);
                cmd.Parameters.AddWithValue("@CEP", _fornecedor.CEP);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um fornecedor no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Fornecedor _fornecedor)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Fornecedor SET 
                                        Nome = @Nome, 
                                        Email = @Email, 
                                        Telefone = @Telefone,
                                        Endereco = @Endereco,
                                        CEP = @CEP, 
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _fornecedor.Id);
                cmd.Parameters.AddWithValue("@Nome", _fornecedor.Nome);
                cmd.Parameters.AddWithValue("@Email", _fornecedor.Email);
                cmd.Parameters.AddWithValue("@Telefone", _fornecedor.Fone);
                cmd.Parameters.AddWithValue("@Endereco", _fornecedor.Endereco);
                cmd.Parameters.AddWithValue("@CEP", _fornecedor.CEP);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar fornecedor no banco de dados", ex) { Data = { { "Id", 1006 } } };
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
                cmd.CommandText = @"DELETE FROM Fornecedor WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir Fornecedor no banco de dados.", ex) { Data = { { "Id", 1007 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Fornecedor> BuscarTodos()
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            Fornecedor fornecedor = new Fornecedor();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Email, Telefone, Endereco, CEP FROM Fornecedor";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = Convert.ToInt32(rd["Id"]);
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Fone = rd["Telefone"].ToString();
                        fornecedor.Endereco = rd["Endereco"].ToString();
                        fornecedor.CEP = rd["CEP"].ToString();
                        fornecedores.Add(fornecedor);

                    }
                    return fornecedores;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os fornecedores no banco de dados", ex);

            }
            finally
            {
                cn.Close();
            }
        }

        public List<Fornecedor> BuscarPorNome(string _nome)
        {
            List<Fornecedor> fornecedores = new List<Fornecedor>();
            //Fornecedor fornecedor = new Fornecedor();
            Fornecedor fornecedor;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Email, Telefone, Endereco, CEP FROM Fornecedor WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = Convert.ToInt32(rd["Id"]);
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Fone = rd["Telefone"].ToString();
                        fornecedor.Endereco = rd["Endereco"].ToString();
                        fornecedor.CEP = rd["CEP"].ToString();
                        fornecedores.Add(fornecedor);
                    }
                }
                return fornecedores;
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
        public Fornecedor BuscarPorId(int _id)
        {
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Email, Telefone, Endereco, CEP FROM Fornecedor WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Fone = rd["Telefone"].ToString();
                        fornecedor.Endereco = rd["Endereco"].ToString();
                        fornecedor.CEP = rd["CEP"].ToString();
                    }
                }
                return fornecedor;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar fornecedores por id no banco de dados", ex) { Data = { { "Id", 10039 } } };
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
