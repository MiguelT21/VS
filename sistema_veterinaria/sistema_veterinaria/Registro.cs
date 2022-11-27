﻿using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_super
{
    public partial class Registro : Form
    {
        MySqlCommand comand;
        MySqlConnection vConexion;
        MySqlDataAdapter vAdapter;
        DataTable vTabla;
        public Registro()
        {
            InitializeComponent();
        }
        

        private void Aceptar_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                //Se abre la conexión
               
                string query = "insert into mascotas values('" + numero_cliente.Text + "','" + nombre_cliente.Text + "', '" + telefono_cliente.Text + "','" + direccion_cliente.Text + "', '" + correo_cliente.Text + "')";
                comand = new MySqlCommand(query,vConexion);
                comand.ExecuteNonQuery();
                Clientes vclientes = new Clientes();

                Registro vadd = new Registro();

                this.Close();

                //
                //Se crea una nueva instancia de la clase MySqlCommnad y se le asigna la sentecia y la conexión
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
            catch (InvalidOperationException Vex)
            {//SI FALLA ALGO LO CAPTURAMOS CON UN TRY - CATH
                MessageBox.Show("Error " + Vex.ToString());
            }
            
        }

        private void actualizarregistro_Click(object sender, EventArgs e)
        {
            
            Aceptar_Btn.Enabled = false;
            try
            {
               
                string nombre=nombre_cliente.Text;
                string id = numero_cliente.Text;
                string telefono = telefono_cliente.Text;
                string direccion = direccion_cliente.Text;
                string correo = correo_cliente.Text;

                string query = "update mascotas set nombre_dueño= '" + nombre + "',telefono= '"+ telefono + "', registro='" + direccion +
                    "',correo='"+ correo + "'where idmascota = '" + id + "';";

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
            catch (MySqlException vEx)
            {
                MessageBox.Show("Error" + vEx.ToString());
            }
            
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            vConexion = new MySqlConnection("datasource=localhost; port = 3306; username=root; password=1938447Mi.; database=db_veterinaria");
            //Abrimos la conexión
            vConexion.Open();
        } 

    }
}
