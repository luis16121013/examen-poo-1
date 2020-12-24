using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    class Pedido
    {
        //reque este es el comentario que se agrego
        //datos cliente
        public string nameClient;
        public string address;
        //datos pizza
        private string namePizza;
        private string tam;
        private double precio;
        private bool entrega = false;

        public int[,] infoPizza = new int[3, 4];

        List<Pedido> pedidos = new List<Pedido>();

        public Pedido(string nombre,string dir) {
            this.nameClient = nombre;
            this.address = dir;

            this.infoPizza[0, 0] = 35;
            this.infoPizza[0, 1] = 50;
            this.infoPizza[0, 2] = 60;
            this.infoPizza[0, 3] = 80;

            this.infoPizza[1, 0] = 40;
            this.infoPizza[1, 1] = 55;
            this.infoPizza[1, 2] = 65;
            this.infoPizza[1, 3] = 90;

            this.infoPizza[2, 0] = 50;
            this.infoPizza[2, 1] = 60;
            this.infoPizza[2, 2] = 75;
            this.infoPizza[2, 3] = 100;

        }
        public double getPrecio() {
            return this.precio;
        }

        public void registrarPizza(int nomPizza, int tamPizza)
        {
            this.namePizza = this.nombrePizza(nomPizza);
            this.tam = this.tamañoPizza(tamPizza);
            this.precio = infoPizza[nomPizza, tamPizza];
        }
        
        public void agregarPedido(Pedido p) {
            pedidos.Add(p);
        }
        public string listarPedidos() {
            string allPedidos = "";
            foreach (var datos in pedidos) {
                if(!datos.entrega){
                    allPedidos += "CLIENTE: " + datos.nameClient + "//DIRECCION: " + datos.address + "//PAGO : $/ " + datos.precio + "\n";
                }
            }
            return allPedidos;
        }
        public void realizarEntrega(string nombre){
            foreach (var datos in pedidos)
            {
                if (datos.nameClient==nombre)
                {
                    datos.entrega = true;
                    break;
                }
            }
        }


        private string nombrePizza(int posicion) {
            if (posicion==0) {
                return "lado oscuro";
            }else if(posicion==1){
                return "yo soy tu padre";
            }else if(posicion==2){
                return "que la fuerza te acompañe";
            }
            return "";
        }
        private string tamañoPizza(int posicion)
        {
            if (posicion == 0)
            {
                return "pequeño";
            }
            else if (posicion == 1)
            {
                return "mediano";
            }
            else if (posicion == 2)
            {
                return "grande";
            }
            else if (posicion == 3)
            {
                return "maestro";
            }
            return "";
        }

    }
}
