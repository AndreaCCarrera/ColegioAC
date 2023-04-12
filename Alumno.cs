using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioAC
{
    public class Alumno:Persona // Así se declara la herencia, no hay extends
    {
        private int id;
        private double media;

        

        public Alumno(string nombre, int edad, string apellidos, Dni dni, int id, double media):base(nombre, edad, apellidos, dni)
        
        {
            this.id = id;
            this.media = media;
        
        }

        public Alumno() : base()

        {
            this.id = 0;
            this.media = 0.0;

        }

        

        public int Id { get => id; set => id = value; }
        public double Media { get => media; set => media = value; }

        public override void SumarEdad() // Override porque es redefinido
        {
            this.Edad = this.Edad + 2;

        }

        public override string ToString()
        {
            return base.ToString()+" "+this.id+" "+this.media;
        }

    }
}
