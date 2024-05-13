using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProdutoDAL
    {
        public void Inserir(Produto _produto)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Produto(Nome, Descricao, CodigoDeBarra, IdMarca, Preco, Custo, Quantidade, IdFornecedor, IdCategoria) 
                                    VALUES(@Nome, @Descricao, @CodigoDeBarra, @IdMarca, @Preco, @Custo, @Quantidade, @IdFornecedor, @IdCategoria)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                cmd.Parameters.AddWithValue("@Descricao", _produto.Descricao);
 
                cmd.Parameters.AddWithValue("@CodigoDeBarra", _produto.CodigoDeBarra);
                cmd.Parameters.AddWithValue("@IdMarca", _produto.IdMarca);
                cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                cmd.Parameters.AddWithValue("@Custo", _produto.Custo);
                cmd.Parameters.AddWithValue("@Quantidade", _produto.Quantidade);
                cmd.Parameters.AddWithValue("@IdFornecedor", _produto.IdFornecedor);
                cmd.Parameters.AddWithValue("@IdCategoria", _produto.IdCategoria);


                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um produto no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Produto _produto)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Produto SET 
                                        Nome = @Nome, 
                                        Descricao = @Descricao, 
                                        IdCategoria = @IdCategoria, 
                                        CodigoDeBarra = @CodigoDeBarra, 
                                        IdMarca = @IdMarca,
                                        Preco = @Preco,
                                        Custo = @Custo,
                                        Quantidade = @Quantidade,
                                        IdFornecedor = @IdFornecedor
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _produto.Id);
                cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                cmd.Parameters.AddWithValue("@Descricao", _produto.Descricao);
                cmd.Parameters.AddWithValue("@IdCategoria", _produto.IdCategoria);
                cmd.Parameters.AddWithValue("@CodigoDeBarra", _produto.CodigoDeBarra);
                cmd.Parameters.AddWithValue("@IdMarca", _produto.IdMarca);
                cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                cmd.Parameters.AddWithValue("@Custo", _produto.Custo);
                cmd.Parameters.AddWithValue("@Quantidade", _produto.Quantidade);
                cmd.Parameters.AddWithValue("@IdFornecedor", _produto.IdFornecedor);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar produto no banco de dados", ex) { Data = { { "Id", 1001 } } };
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
                cmd.CommandText = @"DELETE FROM Produto WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir Produto no banco de dados.", ex) { Data = { { "Id", 1002 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Produto> BuscarTodos()
        {
            List<Produto> produtos = new List<Produto>();
            Produto produto = new Produto();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Descricao, IdCategoria, CodigoDeBarra, IdMarca, Preco, Custo, Quantidade, IdFornecedor FROM Produto";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        produto = new Produto();
                        produto.Id = Convert.ToInt32(rd["Id"]);
                        produto.Nome = rd["Nome"].ToString();
                        produto.Descricao = rd["Descricao"].ToString();
                        produto.IdCategoria = Convert.ToInt32(rd["IdCategoria"]);
                        produto.CodigoDeBarra = rd["CodigoDeBarra"].ToString();
                        produto.IdMarca = Convert.ToInt32(rd["IdMarca"]);
                        produto.Preco = Convert.ToDouble(rd["Preco"]);
                        produto.Quantidade = Convert.ToInt32(rd["Quantidade"]);
                        produto.Custo = Convert.ToDouble(rd["Custo"]);
                        produto.IdFornecedor = Convert.ToInt32(rd["IdFornecedor"]);
                        produtos.Add(produto);

                    }
                    return produtos;
                }

            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os produtos no banco de dados", ex);

            }
            finally
            {
                cn.Close();
            }
        }
        public List<Produto>BuscarPorNome(string _nome)
        {
            List<Produto> produtos = new List<Produto>();
            //Produto produto = new Produto();
            Produto produto;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, Nome, Descricao, CodigoDeBarra, IdMarca, Preco, Custo, Quantidade, IdFornecedor, IdCategoria FROM Produto WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        produto = new Produto();
                        produto.Id = Convert.ToInt32(rd["Id"]);
                        produto.Nome = rd["Nome"].ToString();
                        produto.Descricao = rd["Descricao"].ToString();
                        produto.IdCategoria = Convert.ToInt32(rd["IdCategoria"]);
                        produto.CodigoDeBarra = rd["CodigoDeBarra"].ToString();
                        produto.IdMarca = Convert.ToInt32(rd["IdMarca"]);
                        produto.Preco = Convert.ToDouble(rd["Preco"]);
                        produto.Custo = Convert.ToDouble(rd["Custo"]);
                        produto.Quantidade = Convert.ToInt32(rd["Quantidade"]);
                        produto.IdFornecedor = Convert.ToInt32(rd["IdFornecedor"]);
                        produtos.Add(produto);
                    }
                }
                return produtos;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por nome no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public Produto BuscarPorId(int _id)
        {
            //Produto produto = new Produto();
            Produto produto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Descricao, IdCategoria, CodigoDeBarra, IdMarca, Preco, Custo, Quantidade, IdFornecedor FROM Produto WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                //produto = new Produto();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    produto = new Produto();

                    if (rd.Read())
                    {
                        produto = new Produto();
                        produto.Id = (int)rd["Id"];
                        produto.Nome = rd["Nome"].ToString();
                        produto.Descricao = rd["Descricao"].ToString();
                        produto.IdCategoria = (int)rd["IdCategoria"];
                        produto.CodigoDeBarra = rd["CodigoDeBarra"].ToString();
                        produto.IdMarca = (int)rd["IdMarca"];
                        produto.Preco = Convert.ToDouble(rd["Preco"]);
                        produto.Custo = Convert.ToDouble(rd["Custo"]);
                        produto.Quantidade = (int)rd["Quantidade"];
                        produto.IdFornecedor = (int)rd["IdFornecedor"];
                    }
                    
                }
                return produto;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por id no banco de dados",ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Produto BuscarPorCodigoDeBarra(string _codigodebarra)
        {
            //Produto produto = new Produto();
            Produto produto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Descricao, IdCategoria, CodigoDeBarra, IdMarca, Preco, Custo, Quantidade, IdFornecedor FROM Produto WHERE CodigoDeBarra = @CodigoDeBarra";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@CodigoDeBarra", _codigodebarra);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    produto = new Produto();
                    if (rd.Read())
                    {
                        produto.Id = Convert.ToInt32(rd["Id"]);
                        produto.Nome = rd["Nome"].ToString();
                        produto.Descricao = rd["Descricao"].ToString();
                        produto.IdCategoria = Convert.ToInt32(rd["IdCategoria"]);
                        produto.CodigoDeBarra = rd["CodigoDeBarra"].ToString();
                        produto.IdMarca = Convert.ToInt32(rd["IdMarca"]);
                        produto.Preco = Convert.ToDouble(rd["Preco"]);
                        produto.Custo = Convert.ToDouble(rd["Custo"]);
                        produto.Quantidade = Convert.ToInt32(rd["Quantidade"]);
                        produto.IdFornecedor = Convert.ToInt32(rd["IdFornecedor"]);
                    }
                }
                return produto;
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por codigo de barra no banco de dados");
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
