using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class VendaDAL
    {
        public void Inserir(Venda _venda)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Venda(IdUsuario, IdCliente, IdFormaPagamento, DataVenda, Total) VALUES (@IdUsuario, @IdCliente, @IdFormaPagamento, GETDATE(), @Total) SELECT @@IDENTITY";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdUsuario", _venda.IdUsuario ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdCliente", _venda.IdCliente ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdFormaPagamento", _venda.IdFormaPagamento ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Total", _venda.Total);
                cmd.Connection = cn;
                cn.Open();
                _venda.Id = Convert.ToInt32(cmd.ExecuteScalar());

                foreach (var item in _venda.ItemVendaList)
                {
                    item.IdVenda = _venda.Id;
                    new ItemVendaDAL().Inserir(item);
                }
            }
            catch (Exception ex)
            {
               // throw new Exception("Ocorre um erro ao abrir uma venda no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Venda _venda)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Venda SET IdUsuario = @IdUsuario, 
                                                     IdCliente = @IdCliente,
                                                     IdFormaPagamento = @IdFormaPagamento,
                                                     Total = @Total
                                                     WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _venda.Id);
                cmd.Parameters.AddWithValue("@IdUsuario", _venda.IdUsuario ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdCliente", _venda.IdCliente ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdFormaPagamento", _venda.IdFormaPagamento ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Total", _venda.Total);


                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
                /*foreach (var item in _venda.itemVendaList)
                {
                    new ItemVendaDAL().Inserir(item);
                }*/
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar Venda no banco de dados", ex) { Data = { { "Id", 10064 } } };
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
                cmd.CommandText = @"DELETE FROM Venda WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma venda no banco de dados");
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Venda> BuscarTodos()
        {
            List<Venda> vendas = new List<Venda>();
            Venda venda;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, IdUsuario, IdFormaPagamento, DataVenda, Total FROM Venda";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        venda = new Venda();
                        venda.Id = Convert.ToInt32(rd["Id"]);
                        venda.IdUsuario = Convert.ToInt32(rd["IdUsuario"]);
                        //venda.IdCliente = Convert.ToInt32(rd["IdCliente"]);
                        venda.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        venda.DataVenda = Convert.ToDateTime(rd["DataVenda"]);
                        venda.Total = Convert.ToDouble(rd["Total"]);
                        vendas.Add(venda);
                    }
                    return vendas;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por todas as vendas no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }

        }
        public Venda BuscarPorId(int _id)
        {
            Venda venda = new Venda();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, IdUsuario, IdFormaPagamento, DataVenda, Total FROM Venda WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    venda = new Venda();
                    if (rd.Read())
                    {
                        venda.Id = Convert.ToInt32(rd["Id"]);
                        venda.IdUsuario = Convert.ToInt32(rd["IdUsuario"]);
                        //venda.IdCliente = Convert.ToInt32(rd["IdCliente"]);
                        venda.IdFormaPagamento = Convert.ToInt32(rd["IdFormaPagamento"]);
                        venda.DataVenda = Convert.ToDateTime(rd["DataVenda"]);
                        venda.Total = Convert.ToDouble(rd["Total"]);
                    }
                }
                return venda;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar venda por id no banco de dados");
            }
            finally
            {
                cn.Close();
            }
        }

        public Estatistica BuscarReceita(DateTime _dataInicio, DateTime _dataFim)
        {
            Estatistica estatistica = new Estatistica();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"select 
                ISNULL(SUM(ValorUnitario * Quantidade), 0)Ganhos, 
                ISNULL(SUM(CustoProduto * Quantidade), 0)Gastos, 
                ISNULL(SUM(ValorUnitario * Quantidade), 0) - ISNULL(SUM(CustoProduto * Quantidade), 0)Saldo 
                from ItemVenda
                INNER JOIN Venda
                on Venda.Id = ItemVenda.IdVenda
                WHERE CONVERT(DATETIME, CONVERT(VARCHAR, Venda.DataVenda, 107)) BETWEEN CONVERT(DATETIME, CONVERT(VARCHAR, @DataInicial, 107)) AND CONVERT(DATETIME, CONVERT(VARCHAR, @DataFinal, 107))";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DataInicial", _dataInicio);
                cmd.Parameters.AddWithValue("@DataFinal", _dataFim);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    estatistica = new Estatistica();
                    if (rd.Read())
                    {
                        estatistica.Ganhos = Convert.ToDouble(rd["Ganhos"]);
                        estatistica.Gastos = Convert.ToDouble(rd["Gastos"]);
                        //estatistica.Saldo = Convert.ToDouble(rd["Saldo"]);
                    }
                }
                return estatistica;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar receita por data no banco de dados");
            }
            finally
            {
                cn.Close();
            }

            /*
                select 
                SUM(ValorUnitario * Quantidade)Ganhos, 
                SUM(CustoProduto * Quantidade)Gastos, 
                SUM(ValorUnitario * Quantidade) - SUM(CustoProduto * Quantidade)Saldo 
                from ItemVenda
                INNER JOIN Venda
                on Venda.Id = ItemVenda.IdVenda
                WHERE CONVERT(DATETIME, CONVERT(VARCHAR, Venda.DataVenda, 107)) BETWEEN @DataInicial AND @DataFinal

             */
        }

    }
}