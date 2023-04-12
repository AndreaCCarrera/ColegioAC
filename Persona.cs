using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioAC
{
    public class Persona
    {
        private string nombre;   //String puede ir en minúscula (nativo) o mayúscula (clase String)
        private int edad;
        private string apellidos;
        private Dni dni;

        public Persona() {
            this.nombre = "";
            this.edad = 0;
            this.apellidos = "";
            this.dni = new Dni();
               
        }

        public Persona(string nombre, int edad, string apellidos, Dni dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.apellidos = apellidos;
            this.dni = dni;

        }


        public virtual void SumarEdad() { // Virtual para que sepa que va a ser redefinido en las clases hijas

            this.edad = this.edad + 1;
        
        
        
        }        // Properties, exclusivas de C#, como los gets y los sets

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public Dni Dni { get => dni; set => dni = value; }

        public override string ToString() // La t en Java es minúscula y en C# es mayúscula, igual que todos los métodos
        {
            return this.nombre+" "+this.edad+" "+this.apellidos+" "+this.dni; // En C# el super se llama base
        }


    }
}
