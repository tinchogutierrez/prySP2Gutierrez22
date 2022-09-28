using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP2Gutierrez
{
    public partial class frmPrincipal : Form
    {
        //DECLARO VARIABLES//
        


        public frmPrincipal()
        {
            InitializeComponent();
        }
       
        private void mrcTipo_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDias.Enabled = true;
            if (lstPersonas.Text == "0" )
            {
                txtDias.Enabled = false;
            }
        }

        private void chkCocina_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void lstTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPersonas.Enabled = true;
            if (lstTipo.Text == "" ) 
            {
                
            }
            if (lstTipo.SelectedItem == "A")
            {
                lstPersonas.Items.Clear();
                lstPersonas.Items.Add(1);
                lstPersonas.Items.Add(2);
                lstPersonas.Items.Add(3);
                lstPersonas.Items.Add(4);
            }
            if (lstTipo.SelectedItem == "B")
            {
                lstPersonas.Items.Clear();
                lstPersonas.Items.Add(1);
                lstPersonas.Items.Add(2);
                lstPersonas.Items.Add(3);
                lstPersonas.Items.Add(4); 
                lstPersonas.Items.Add(5); 
                lstPersonas.Items.Add(6);   
                lstPersonas.Items.Add(7);   
                lstPersonas.Items.Add(8);

            }

        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            mrcAdicionales.Enabled = true ; mrcPago.Enabled = true ;    
            // optEfectivo.Enabled=true; optTarjeta.Enabled=true;
            // chkCocina.Enabled = true; chkHeladera.Enabled = true; chkTelevision.Enabled = true; 
            if (txtDias.Text == "")
            {
                mrcAdicionales.Enabled= false ; mrcPago.Enabled = false ;   
                // optEfectivo.Enabled = false; optTarjeta.Enabled = false;
                // chkCocina.Enabled = false; chkHeladera.Enabled = false; chkTelevision.Enabled = false;
            }
        }

        private void chkHeladera_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void chkTelevision_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            
            if (optTarjeta.Checked == true)
            {
                lstTarjetas.Enabled = true;
                lblTarjetas.Enabled = true;  
            }
            else
            {
                lstTarjetas.Enabled = false;
                lblTarjetas.Enabled = false;
            }
            if (optTarjeta.Checked == true && lstTarjetas.SelectedIndex != -1)
            {
                mrcTitular.Enabled = true;
            }
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.Enabled = true;
            if (txtNombre.Text == "")
            {
                txtTelefono.Enabled = false; 
            }
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            
            mrcTitular.Enabled = true;
            if (optEfectivo.Checked == false)
            {
                mrcTitular.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtTelefono.Text != "")
            {
                lblDatos.Text = "Tipo: " + lstTipo.Text;
                lblDatos.Text += "\nPersonas : " + lstPersonas.Text;
                lblDatos.Text += "\nDias: " + txtDias.Text;
                lblDatos.Text += "\nAdicionales: ";
            }
            if (chkCocina.Checked == true)
            {
                lblDatos.Text += "\n- Cocina: Si";
            }
            else
            {
                lblDatos.Text += "\n- Cocina: No";
            }
            if (chkHeladera.Checked == true)
            {
                lblDatos.Text += "\n- Heladera: Si";
            }
            else
            {
                lblDatos.Text += "\n- Heladera: No";
            }
            if (chkTelevision.Checked == true)
            {
                lblDatos.Text += "\n- Television: Si";
            }
            else
            {
                lblDatos.Text += "\n- Television: No";
            }
            if (optEfectivo.Checked == true)
            {
                lblDatos.Text += "\nForma de Pago: Efectivo";
            }
            if (optTarjeta.Checked == true)
            {
                lblDatos.Text += "\nFroma de Pago: Tarjeta" + lstTarjetas.SelectedItem; 
                    

            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
                                            // Cargar datos iniciales segun pdf //
            // lstTipo.SelectedIndex = 0;
            // lstPersonas.SelectedIndex = 0;
            // txtDias.Text = "1";
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese únicamente números");
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese únicamente números");
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
            if (txtTelefono.Text == "")
            {
                btnAceptar.Enabled = false;
            }
        }

        private void lstTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled =true;  
            mrcTitular.Enabled = true;

        }
    }
    
}
