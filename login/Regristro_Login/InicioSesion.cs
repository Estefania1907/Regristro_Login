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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Regristro_Login
{
    
    public partial class InicioSesion : Form
    {
        int contador = 0;
        
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                /// <param name="sender" Lee la contraseña ></param>
                /// <param name="e"></param>
                
                TextReader Inicio = new StreamReader(txtNombre.Text + ".txt");

                if (Inicio.ReadLine() == txtClave.Text)
                {
                    MessageBox.Show("Inicio Correctamente");
                }

                else
                {
                    /// <param name="sender" Analiza fallos de seguridad ></param>
                    /// <param name="e"></param>
                    
                    contador++;
                    MessageBox.Show("El limite de intestos son 3 llevas:  " + contador );
                    
                    if (contador==3)
                    {
                        /// <param name="sender" limitante de errores en fallas ></param>
                        /// <param name="e"></param>
                        
                        MessageBox.Show("Haz llegado al limite de intentos, las cajas de textos o TextBox se bloquearan ");
                        txtNombre.Enabled=false ;
                        txtClave.Enabled = false;
                    }
                }

            }
            catch (Exception y)
            {
                MessageBox.Show("Hubo un error" + y, "Error");
            }
                
            }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtClave.Clear();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Atras = new Form1();
            Atras.Show();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
