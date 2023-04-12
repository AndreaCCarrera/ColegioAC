using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ColegioAC
{
    public class Aula
    {
        private string nombre;
        private Profesor p;
        private List<Alumno> lista; // En lugar de ArrayList

        public string Nombre { get => nombre; set => nombre = value; }
        public Profesor P { get => p; set => p = value; }
        public List<Alumno> Lista { get => lista; set => lista = value; }

        public Aula() {

            this.p = new Profesor();
            this.nombre = "";
            this.lista = new List<Alumno>();
        
        }

        public Aula(string nombre, Profesor p)
        {

            this.p = p;
            this.nombre = nombre;
            this.lista = new List<Alumno>();

        }

        

        public void Mostrar() {

            // foreach en lugar de for 

            foreach (Alumno a in lista) {
                Console.WriteLine(a);
            
            }
       
        }

        public override string ToString() // La t en Java es minúscula y en C# es mayúscula, igual que todos los métodos
        {
            return this.nombre + " " + this.p; // En C# el super se llama base
        }

        public void Anadir(Alumno a) {

            lista.Add(a);
        
        }

        public void Borrar(int id) {

            foreach (Alumno a in lista)
            {

                if (a.Id == id)
                {
                    lista.Remove(a);
                    break;

                }
                
            }



        }

        public void MostrarAula() {


            Console.WriteLine(ToString());
            Mostrar();
        }



    }
}
