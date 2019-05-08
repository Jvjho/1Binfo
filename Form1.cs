using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //vai pedir depois,então fazemos agora
namespace projeto
{
    public partial class Form1 : Form
    {
        //DESKTOP-8NFA3IQ
        //DESKTOP-S28P9M1
        //declarando a string de conexão com o banco de dados
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8NFA3IQ;Initial Catalog=ProjetoBanco;User ID=sa;Password=1234567");//instanciar = SqlConnection representado por con
        SqlCommand comando = new SqlCommand();    // e Sqlcommand é representado por   comando
        public Form1()
        {
            InitializeComponent();
            comando.Connection = con;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            con.Open();
            comando.CommandText = "INSERT INTO dados (ID, nome) VALUES('" + txtID.Text  + "', '" + txtnome.Text + "')";
            comando.ExecuteNonQuery();
            con.Close();

            txtID.Text = "";
            txtnome.Text = "";
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }
    }
}
