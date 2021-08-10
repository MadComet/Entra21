﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExc
{
    public partial class CadastroProduto : Form
    {

        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtBoxNome.Text;
            string preco = txtBoxPreco.Text;
            string qtdEstoque = txtBoxQtdEstoque.Text;

            if (nome != null || preco != null || qtdEstoque != null)
            {
                string insert = $"INSERT into dbo.Produto (Nome,Preco,QtdEstoque) values ('{nome}','{preco}','{qtdEstoque}')";
                SqlCommand cmd = new SqlCommand(insert, DbConncetion.Connection);
                DbConncetion.Connection.Open();
                DbConncetion.Connection.Close();
                MessageBox.Show("Produto Salvo");
            }
            else
            {
                MessageBox.Show("Todos os campos são Obrigatórios!");
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            this.FindForm().Hide();
            produto.Show();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            txtBoxNome.Clear();
            txtBoxPreco.Clear();
            txtBoxQtdEstoque.Clear();
        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {

            this.produtoTableAdapter.Fill(this.excEntra21DataSet.Produto);


        }

        private void buttonRecarregar_Click(object sender, EventArgs e)
        {           
            
            //BindingSource sr = new BindingSource();
            //sr.DataSource = GetData("SELECT * from dbo.Produto");
            //dataGridView2.DataSource = sr;

            dataGridView2.DataSource = GetData("SELECT * from dbo.Produto");


        }

        private DataTable GetData(string sqlCommand)
        {
            string connectionString = DbConncetion.Connection.ConnectionString;

            SqlConnection northwindConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sqlCommand, northwindConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);

            return table;
        }
    }
}