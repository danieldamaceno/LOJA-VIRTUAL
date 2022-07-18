using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace LOJAVIRTUAL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;User Id=root;database=Loja; password=995628379l");
            string query = "INSERT INTO carrinho(Marca,Produto,Preco) VALUES(@Marca, @produto, @preco)";
            MySqlCommand command = new MySqlCommand(query, conexao);

            command.Parameters.AddWithValue("@Marca", "errea");
            command.Parameters.AddWithValue("@Produto", "Camiseta");
            command.Parameters.AddWithValue("@Preco", "299");

            command.Connection.Open();
            command.ExecuteNonQuery();
        }


        protected void Button2_Click1(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;User Id=root;database=Loja; password=995628379l");
            MySqlCommand comando = new MySqlCommand("delete from carrinho", conexao);
            try
            {
                conexao.Open();
                GridView1.DataSource = comando.ExecuteReader();
                GridView1.DataBind();
            }

            finally
            {
                conexao.Close();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;User Id=root;database=Loja; password=995628379l");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM carrinho", conexao);
            try
            {
                conexao.Open();
                GridView1.DataSource = comando.ExecuteReader();
                GridView1.DataBind();
            }
            finally
            {
                conexao.Close();

            }
        }
    }
}