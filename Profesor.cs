using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioAC
{
    public class Profesor : Persona

    {

        private string titulacion;
        private double salario;

        public Profesor() : base(){

            this.titulacion = "";
            this.salario = 0.0;

}


        public Profesor(string nombre, int edad, string apellidos, Dni dni, string titulacion, double salario) : base(nombre, edad, apellidos, dni)
        {

            this.titulacion = titulacion;
            this.salario = salario;

        }

        public string Titulacion { get => titulacion; set => titulacion = value; }
        public double Salario { get => salario; set => salario = value; }


        public override void SumarEdad() // Override porque es redefinido
        {
            this.Edad = this.Edad + 5;

        }

        public override string ToString()
        {
            return base.ToString()+" "+this.titulacion+" "+this.salario;
        }
    }
}
