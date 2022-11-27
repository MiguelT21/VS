using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_super
{
    public partial class Eliminar : Form
    {
        MySqlCommand comand;
        MySqlConnection vConexion;
        MySqlDataAdapter vAdapter;
        DataTable vTabla;
        public Eliminar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                vConexion = new MySqlConnection("datasource=localhost; port = 3306; username=root; password=1938447Mi.; database=db_veterinaria");
                vConexion.Open();
                int id = Convert.ToInt16(nombre_eliminar.Text);

                string query = ("delete from mascotas where idmascota = " + id);

                comand = new MySqlCommand(query, vConexion);
                comand.ExecuteNonQuery();

                this.Close();
                //Para que se actualice nuestro registro en el datagridview
                string v = "Select * from mascotas";
                comand = new MySqlCommand(v, vConexion);
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
            catch (InvalidOperationException vEx)
            {
                MessageBox.Show("Error" + vEx.ToString());  
            }

        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {

        }
    }
}
