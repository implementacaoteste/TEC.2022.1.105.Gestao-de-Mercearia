using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FormaPagamentoDAL
    {
        public void Inserir(FormaPagamento _pagamento)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO FormaPagamento(Tipo, Descricao, Troco) 
                                    VALUES(@Tipo, @Descricao, @Troco)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Tipo", _pagamento.Tipo);
                cmd.Parameters.AddWithValue("@Descricao", _pagamento.Descricao);
                cmd.Parameters.AddWithValue("@Troco", _pagamento.Troco);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma forma de pagamento no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(FormaPagamento _pagamento)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE FormaPagamento SET Tipo = @Tipo,
                                                          Descricao = @Descricao,
                                                          Troco = @Troco
                                                          WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _pagamento.Id);
                cmd.Parameters.AddWithValue("@Tipo", _pagamento.Tipo);
                cmd.Parameters.AddWithValue("@Descricao", _pagamento.Descricao);
                cmd.Parameters.AddWithValue("@Troco", _pagamento.Troco);


                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar Forma de Pagamento no banco de dados", ex) { Data = { { "Id", 10071 } } };
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
                cmd.CommandText = @"DELETE FROM FormaPagamento WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir Forma de pagamento no banco de dados.", ex) { Data = { { "Id", 10072 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<FormaPagamento> BuscarTudo()
        {
            List<FormaPagamento> pagamentoList = new List<FormaPagamento>();
            FormaPagamento pagamento;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Tipo, Descricao, Troco FROM FormaPagamento";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        pagamento = new FormaPagamento();
                        pagamento.Id = (int)rd["Id"];
                        pagamento.Tipo = rd["Tipo"].ToString();
                        pagamento.Descricao = rd["Descricao"].ToString();
                        pagamento.Troco = Convert.ToDouble(rd["Troco"]);
                        pagamentoList.Add(pagamento);
                    }
                }
                return pagamentoList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar forma de pagamento no banco de dados", ex) { Data = { { "Id", 10035 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public FormaPagamento BuscarPorId(int _id)
        {
            FormaPagamento pagamento;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Tipo, Descricao, Troco FROM FormaPagamento WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    pagamento = new FormaPagamento();
                    if (rd.Read())
                    {
                        pagamento.Id = (int)rd["Id"];
                        pagamento.Tipo = rd["Tipo"].ToString();
                        pagamento.Descricao = rd["Descricao"].ToString();
                        pagamento.Troco = Convert.ToDouble(rd["Troco"]);
                    }
                }
                return pagamento;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar formas de pagamento por id no banco de dados", ex) { Data = { { "Id", 10034 } } };
            }
            finally
            {
                cn.Close();
            }
        }


    }
}
