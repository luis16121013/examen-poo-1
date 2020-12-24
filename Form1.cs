using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbPrecio.Text = "$/0";
            tbEstadoPedido.Text = "en espera";
            pedidosCliente = new Pedido("", "");
        }
        Pedido pedidosCliente;
       

        private void tbnComprar_Click(object sender, EventArgs e)
        {
            Pedido cliente = new Pedido(tbNombreCliente.Text,tbDireccion.Text);
            int tamaño = 0;
            int nombre = 0;
           
            if (rbNombre1.Checked){
                nombre = 0; 
            } else if (rbNombre2.Checked){ 
                nombre = 1;
            } else if (rbNombre3.Checked) { 
                nombre = 2; 
            }


            if (checkBox1.Checked) { 
                tamaño = 0; 
            } else if (checkBox2.Checked) { 
                tamaño = 1; 
            } else if (checkBox3.Checked) { 
                tamaño = 2; 
            } else if (checkBox4.Checked) { 
                tamaño = 3; 
            }


            cliente.registrarPizza(nombre, tamaño);
            pedidosCliente.agregarPedido(cliente);
            tbPrecio.Text = ""+cliente.getPrecio();
            richTextBox1.Clear();
            richTextBox1.AppendText(pedidosCliente.listarPedidos());
        }

        private void btnVerificarCobro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("realizar el cobro de $/40.00");
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            pedidosCliente.realizarEntrega(tbclienteCobrar.Text);
            richTextBox1.Clear();
            richTextBox1.AppendText(pedidosCliente.listarPedidos());
            MessageBox.Show("entrega realizada");
        }
    }
}
