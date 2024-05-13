using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ItemVendaDAL
    {
        public void Inserir(ItemVenda _item)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO ItemVenda(IdProduto, IdVenda, Quantidade, ValorUnitario, CustoProduto, SubTotal) 
                                    VALUES(@IdProduto, @IdVenda, @Quantidade, @ValorUnitario, @CustoProduto, @SubTotal)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdProduto", _item.IdProduto);
                cmd.Parameters.AddWithValue("@IdVenda", _item.IdVenda);
                cmd.Parameters.AddWithValue("@Quantidade", _item.Quantidade);
                cmd.Parameters.AddWithValue("@ValorUnitario", _item.ValorUnitario);
                cmd.Parameters.AddWithValue("@CustoProduto", _item.CustoProduto);
                cmd.Parameters.AddWithValue("@SubTotal", _item.SubTotal);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir um item no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(ItemVenda _item)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE ItemVenda SET IdProduto = @IdProduto,
                                                     IdVenda = @IdVenda,
                                                     Quantidade = Quantidade,
                                                     ValorUnitario = @ValorUnitario,
                                                     CustoProduto = @CustoProduto,
                                                     SubTotal = @SubTotal
                                                     WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _item.Id);
                cmd.Parameters.AddWithValue("@IdProduto", _item.IdProduto);
                cmd.Parameters.AddWithValue("@IdVenda", _item.IdVenda);
                cmd.Parameters.AddWithValue("@Quantidade", _item.Quantidade);
                cmd.Parameters.AddWithValue("@ValorUnitario", _item.ValorUnitario);
                cmd.Parameters.AddWithValue("@CustoProduto", _item.CustoProduto);
                cmd.Parameters.AddWithValue("@SubTotal", _item.SubTotal);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar Item no banco de dados", ex) { Data = { { "Id", 10065 } } };
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
                cmd.CommandText = @"DELETE FROM ItemVenda WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um item no banco de dados.", ex) { Data = { { "Id", 10066 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public ItemVenda BuscarPorIdVenda(int _IdVenda)
        {
            ItemVenda item;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT IdProduto, IdVenda, Quantidade, ValorUnitario, CustoProduto, SubTotal FROM ItemVenda WHERE IdVenda = @IdVenda";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdVenda", _IdVenda);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    item = new ItemVenda();
                    if (rd.Read())
                    {
                        item.Id = (int)rd["Id"];
                        item.IdProduto = (int)rd["IdProduto"];
                        item.IdVenda = (int)rd["IdVenda"];
                        item.Quantidade = (int)rd["Quantidade"];
                        item.ValorUnitario = Convert.ToDouble(rd["ValorUnitario"]);
                        item.CustoProduto = Convert.ToDouble(rd["CustoProduto"]);
                        item.SubTotal = Convert.ToDouble(rd["SubTotal"]);

                    }
                }
                return item;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um Item por Id de Venda no banco de dados", ex) { Data = { { "Id", 10068 } } };
            }
            finally
            {
                cn.Close();
            }
        }


    }
    
}
