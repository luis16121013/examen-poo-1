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

        List<Pedido> ListPedidos = new List<Pedido>();

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

        //eston es el metodo que se encarga de registrar los datos la pizza
        //pero no lo agrega a las lista de pedidos
        //*calcular el precio == infoPizza[nombre][tamaño]
        public void registrarPizza(int nomPizza, int tamPizza)
        {
            //se encarga de retornar el nombre de la pizza(indice-fila)
            this.namePizza = this.nombrePizza(nomPizza);

            //se encarga de retornar el tamaño de la pizza(indice-columna)
            this.tam = this.tamañoPizza(tamPizza);

            //se encarga calcular el precio mediante los indices
            this.precio = infoPizza[nomPizza, tamPizza];
        }
        
        //se encarga de agregar el pedido a la lista
        public void agregarPedido(Pedido p) {//recibe un objeto de tipo pedido
            ListPedidos.Add(p);//se agrega a la lista
        }


        //lista todos los pedidos que esten en "ESPERA"
        public string listarPedidos() {
            string allPedidos = "";//creamos un contenedor de la lista vacia
            foreach (var datos in ListPedidos) {//recorre toda la lista
                //(!datos.entrega)
                if(datos.entrega==false){//filtra solo los que se encuentren en "ESPERA"
                    allPedidos += "CLIENTE: " + datos.nameClient + "//DIRECCION: " + datos.address + "//PAGO : $/ " + datos.precio + "\n";
                }
            }
            return allPedidos;//retorna en formato text la lista
        }

        //cambia el valor de "ESPERA=false" a "ENTREGADO=true"
        public void realizarEntrega(string nombre){//recibe el nombre del  cliente
            foreach (var datos in ListPedidos)//busca en la lista el cliente
            {
                if (datos.nameClient==nombre)//verifica el cliente
                {
                    datos.entrega = true;//cambiamos el estado a entregado
                    break;//terminamos el bucle
                }
            }
        }


        private string nombrePizza(int posicion) {//retorna el nombre de la pizza
            if (posicion==0) {
                return "lado oscuro";
            }else if(posicion==1){
                return "yo soy tu padre";
            }else if(posicion==2){
                return "que la fuerza te acompañe";
            }
            return "";
        }
        private string tamañoPizza(int posicion)//retorna el tamaño de la pizza
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
