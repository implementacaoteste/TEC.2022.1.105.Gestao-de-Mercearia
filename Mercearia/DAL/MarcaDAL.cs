using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MarcaDAL
    {
        public void Inserir(Marca _marca)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Marca(Nome) 
                                    VALUES(@Nome)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _marca.Nome);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu erro ao tentar inserir uma marca no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Marca _marca)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Marca SET Nome = @Nome WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _marca.Id);
                cmd.Parameters.AddWithValue("@Nome", _marca.Nome);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar Marca no banco de dados", ex) { Data = { { "Id", 10032 } } };
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
                cmd.CommandText = @"DELETE FROM Marca WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir marca no banco de dados.", ex) { Data = { { "Id", 10033 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Marca BuscarPorId(int _id)
        {
            //Marca marca = new Marca();
            Marca marca;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome FROM Marca WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    marca = new Marca();
                    if (rd.Read())
                    {
                        marca.Id = (int)rd["Id"];
                        marca.Nome = rd["Nome"].ToString();
                    }
                }
                return marca;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar marcas por id no banco de dados", ex) { Data = { { "Id", 10034 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Marca> BuscarTudo()
        {
            List<Marca> marcaList = new List<Marca>();
            Marca marca = new Marca();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome FROM Marca";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        marca = new Marca();
                        marca.Id = (int)rd["Id"];
                        marca.Nome = rd["Nome"].ToString();
                        marcaList.Add(marca);
                    }
                }
                return marcaList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar marca no banco de dados", ex) { Data = { { "Id", 10035 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
