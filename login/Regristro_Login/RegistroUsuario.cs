using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
namespace Regristro_Login
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /// <param name="sender"Limpia o borra lo que se encuentre en la caja de texto "TextBox" ></param>
            /// <param name="e"></param>
            txtNombre.Clear();
            txtClave.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                /// <param name="sender" Guarda archivos de TXT en carpeta "debug" ></param>
                /// <param name="e"></param>
                TextWriter RegistroUsuario = new StreamWriter(@"C:\Users\57302\Documents\Tareas Visual\login\Regristro_Login\bin\Debug\" + txtNombre.Text + ".txt", true);
                RegistroUsuario.WriteLine(txtClave.Text);
                RegistroUsuario.Close();

                /// <param name="sender" mensaje al usuario (InicioSesion) ></param>
                /// <param name="e"></param>
                
                MessageBox.Show("Se registro correctamente");
            }
            catch (Exception x)
            {
                MessageBox.Show("Hubo un error" + x, "Error");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            /// <param name="sender" Retroceso a pestaña inicial o anterior ></param>
            /// <param name="e"></param>
            
            this.Hide();
            Form1 Atras = new Form1();
            Atras.Show();
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
