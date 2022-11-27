using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace sistema_super
{
    public partial class Form1 : Form
    {
        //Variables globales;
        MySqlCommand comand;
        MySqlConnection vConexion;
        MySqlDataAdapter vAdapter;
        DataTable vTabla;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SERVER DATOS DEL SERVIDOR
            String servidor = "datasource=localhost; port = 3306; username=root; password=1938447Mi.; database=db_veterinaria";
            try
            {
                //Se abre la conexión
                vConexion = new MySqlConnection(servidor);
                //Abrimos la conexión
                vConexion.Open();
            }
            catch (MySqlException Vex)
            {//SI FALLA ALGO LO CAPTURAMOS CON UN TRY - CATH
                MessageBox.Show("Error " + Vex.ToString());
            }
        }

        private void tabla_clientes_Click(object sender, EventArgs e)
        {
            //Se crea una nueva instancia de la clase MySqlCommnad y se le asigna la sentecia y la conexión
            string query = "Select * from mascotas";
            comand = new MySqlCommand(query, vConexion);
            //Método que ejecuta la sentencia
            comand.ExecuteNonQuery();

            vAdapter = new MySqlDataAdapter();

            vAdapter.SelectCommand = comand;
            vTabla = new DataTable();
            vAdapter.Fill(vTabla);
            Clientes ob = new Clientes();
            ob.datagridclientes.DataSource = vTabla;
            ob.Show();
        }

        private void salido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerrar sesión?", "Esta apunto de cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                vConexion.Close();
                this.Close();
                login log = new login();
                log.Show();
                log.mensaje.Text = "Se ha cerrado la sesión";
            }
        }

        
    }
}
