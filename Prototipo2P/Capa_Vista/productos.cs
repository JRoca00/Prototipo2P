using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;

namespace Capa_Vista
{
    public partial class productos : Form
    {
        string table = "tbl_productos";
        Controlador cn = new Controlador();


        public productos()
        {
            InitializeComponent();
        }


        public void limpiar()
        {
            txtnombre.Text = "";
            txtdescri.Text = "";
            txtcategoria.Text = "";
            txtnombre.Text = "";
            txtmarca.Text = "";

        }

        public void validaringre()
        {

            if (txtnombre.Text == "" || txtdescri.Text == "" || txtcategoria.Text == "" || txtmarca.Text == "")
            {

                MessageBox.Show("Debe completar la informacion");



            }
            else
            {

                TextBox[] textbox = { txtdescri, txtcategoria, txtnombre, txtmarca };
                cn.ingresar(textbox, table);
                string message = "Registro Guardado";
                limpiar();
                MessageBox.Show(message);
            }

        }


        public void validaractua()
        {
            
            if (txtnombre.Text == "" || txtdescri.Text == "" || txtcategoria.Text == "" || txtmarca.Text == "")
            {

                MessageBox.Show("Debe completar la informacion");



            }
            else
            {
                
                TextBox[] textbox = { txtdescri, txtcategoria, txtnombre, txtmarca };
                int valor1 = int.Parse(txtBusqueda.Text);
                string campo = "pk_codigo_producto = ";
                cn.actualizar(textbox, table, campo, valor1);
            }

        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            validaringre();
        }





        private void btnmodificar_Click(object sender, EventArgs e)
        {
            validaractua();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            try
            {


                if (result == DialogResult.Yes)
                {

                    int campo = int.Parse(txtBusqueda.Text);
                    string condicion = "pk_codigo_producto = ";
                    cn.eliminar(table, condicion, campo);
                    string message1 = "Registro eliminado ";
                    limpiar();
                    MessageBox.Show(message1);
                }
                else
                {
                    limpiar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se puede eliminar por permisos asignados");
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }
        }

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(table);
            dataGridView1.DataSource = dt;

        }

        private void btnver_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
