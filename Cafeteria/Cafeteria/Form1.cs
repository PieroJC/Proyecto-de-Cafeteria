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


namespace Cafeteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection con;
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-K90C5VP;Initial Catalog=dbobodegas;Integrated Security=True";
            try
            {
                con.Open();
                MessageBox.Show("Conexion realizada satisfactoriamente");
            }
            catch(Exception)
            {
                MessageBox.Show("Conexion Fallida");
            }
        }

        private void txt_idCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //crear la variable de la sentencia
                SqlCommand sql = new SqlCommand("INSERT INTO `tblCliente` (`idCli`, `nomCli`, `apeCli`, `dniCli`, `dirCli`,`telCli`,`fechaNac`) VALUES (?,?,?,?,?,?,);", con);
                //añadir los parametros de la consulta
                sql.Parameters.Add("@idCli", SqlDbType.VarChar, 4).Value = txt_idCli.Text;
                sql.Parameters.Add("@nomCli", SqlDbType.VarChar, 30).Value = txt_nomCli.Text;
                sql.Parameters.Add("@apeCli", SqlDbType.VarChar, 30).Value = txt_apeCli.Text;
                sql.Parameters.Add("@dniCli", SqlDbType.VarChar, 8).Value = txt_dniCli.Text;
                sql.Parameters.Add("@dirCli", SqlDbType.VarChar, 50).Value = txt_dirCli.Text;
                sql.Parameters.Add("@telCli", SqlDbType.VarChar, 9).Value = txt_telCli.Text;
                sql.Parameters.Add("@fechaNac", SqlDbType.DateTime).Value = date_fechaNac.Text;

               
                //mensaje de salida
                MessageBox.Show("Cliente guardado correctamente.");
            }
            catch (Exception)
            {

                MessageBox.Show("Cliente no Guardado");
            }
            
            con.Close();
        }
    }
}
