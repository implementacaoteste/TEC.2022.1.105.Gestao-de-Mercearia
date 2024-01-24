﻿using BLL;
using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIGestaoMercearia
{
    public partial class FormInicializarVenda : Form
    {
        int id;

        public Produto produtoAtual { get; private set; }

        public FormInicializarVenda(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    bindingSourceVenda.EndEdit();
                    Venda venda = (Venda)bindingSourceVenda.Current;

                    if (id == 0)
                        new VendaBLL().Inserir(venda);

                    MessageBox.Show("Registro salvo com sucesso!");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FormInicializarVenda_Load(object sender, EventArgs e)
        {
            /*
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Venda(IdFuncionario, IdCliente, IdFormaPagamento, DataVenda, Total) VALUES (@IdFuncionario, @IdCliente, @IdFormaPagamento, @DataVenda, @Total)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@IdFuncionario", Constantes.IdUsuarioLogado);
                cmd.Parameters.AddWithValue("@IdCliente", null);
                cmd.Parameters.AddWithValue("@IdFormaPagamento", null);
                cmd.Parameters.AddWithValue("@DataVenda", DateTime.Now.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Total", 0);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorre um erro ao abrir uma venda no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }*/







        }
    }
}
