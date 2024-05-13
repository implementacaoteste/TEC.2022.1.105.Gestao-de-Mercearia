using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EstoqueDAL
    {

        public void Inserir(Estoque _estoque)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Estoque(DataDeEntrada, DataDeSaida, EstoqueMinimo, EstoqueMaximo, QuantidadeEmEstoque,IdProduto) 
                                    VALUES(@DataDeEntrada, @DataDeSaida, @EstoqueMinimo, @EstoqueMaximo, @QuantidadeEmEstoque, @IdProduto)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@DataDeEntrada", _estoque.DatadeEntrada);
                cmd.Parameters.AddWithValue("@DataDeSaida", _estoque.DatadeSaida);
                cmd.Parameters.AddWithValue("@EstoqueMinimo", _estoque.EstoqueMinimo);
                cmd.Parameters.AddWithValue("@EstoqueMaximo", _estoque.EstoqueMaximo);
                cmd.Parameters.AddWithValue("@QuantidadeEmEstoque", _estoque.QtdEstoque);
                cmd.Parameters.AddWithValue("@IdProduto", _estoque.IdProduto);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir algo no estoque dentro do banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Estoque _estoque)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Estoque SET DataDeEntrada = @DataDeEntrada, DataDeSaida = @DataDeSaida, EstoqueMinimo = @EstoqueMinimo, EstoqueMaximo = @EstoqueMaximo, QuantidadeEmEstoque = @QuantidadeEmEstoque, IdProduto = @IdProduto WHERE Id = @Id"; 
                                    
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _estoque.Id);
                cmd.Parameters.AddWithValue("@DataDeEntrada", _estoque.DatadeEntrada);
                cmd.Parameters.AddWithValue("@DataDeSaida", _estoque.DatadeSaida);
                cmd.Parameters.AddWithValue("@EstoqueMinimo", _estoque.EstoqueMinimo);
                cmd.Parameters.AddWithValue("@EstoqueMaximo", _estoque.EstoqueMaximo);
                cmd.Parameters.AddWithValue("@QuantidadeEmEstoque", _estoque.QtdEstoque);
                cmd.Parameters.AddWithValue("@IdProduto", _estoque.IdProduto);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar estoque no banco de dados", ex) { Data = { { "Id", 20 } } };
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
                cmd.CommandText = @"DELETE FROM Estoque WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir estoque no banco de dados.", ex) { Data = { { "Id", 21 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Estoque BuscarPorId(int _id)
        {
            //Estoque estoque = new Estoque();
            Estoque estoque;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, DataDeEntrada, DataDeSaida, EstoqueMinimo, EstoqueMaximo, QuantidadeEmEstoque, IdProduto FROM Estoque WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    estoque = new Estoque();
                    if (rd.Read())
                    {
                        estoque.Id = Convert.ToInt32(rd["Id"]);
                        estoque.DatadeEntrada = Convert.ToDateTime(rd["DataDeEntrada"]); 
                        estoque.DatadeSaida = Convert.ToDateTime(rd["DataDeSaida"]);
                        estoque.EstoqueMinimo = Convert.ToInt32(rd["EstoqueMinimo"]); 
                        estoque.EstoqueMaximo = Convert.ToInt32(rd["EstoqueMaximo"]);
                        estoque.QtdEstoque = Convert.ToInt32(rd["QuantidadeEmEstoque"]);
                        estoque.IdProduto = Convert.ToInt32(rd["IdProduto"]);
                    }
                }
                return estoque;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar clientes por id no banco de dados", ex) { Data = { { "Id", 18 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Estoque> BuscarTudo()
        {

            List<Estoque> estoqueList = new List<Estoque>();
            Estoque estoque = new Estoque();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandText = @"SELECT Id, DataDeEntrada, DataDeSaida, EstoqueMinimo, EstoqueMaximo, QuantidadeEmEstoque, IdProduto FROM Estoque";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        estoque = new Estoque();
                        estoque.Id = (int)rd["Id"];
                        estoque.DatadeEntrada = Convert.ToDateTime(rd["DataDeEntrada"]);
                        estoque.DatadeSaida = Convert.ToDateTime(rd["DataDeSaida"]);
                        estoque.EstoqueMinimo = Convert.ToInt32(rd["EstoqueMinimo"]); 
                        estoque.EstoqueMaximo = Convert.ToInt32(rd["EstoqueMaximo"]);
                        estoque.QtdEstoque = Convert.ToInt32(rd["QuantidadeEmEstoque"]);
                        estoque.IdProduto = Convert.ToInt32(rd["IdProduto"]);
                        estoqueList.Add(estoque);
                    }
                }
                return estoqueList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar estoque no banco de dados", ex) { Data = { { "Id", 16 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
