 using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioAC 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dni d = new Dni(1111111);
             Dni d1 = new Dni(22222222);
             Dni d2 = new Dni(33333333);
             Dni d3 = new Dni(44444444);
             Dni d4 = new Dni(55555555);
             Dni d5 = new Dni(66666666);
             Persona p = new Persona("Juan", 25, "Pérez Martínez", d);
             Alumno a = new Alumno("María", 22, "Jiménez Alcázar", d1, 003, 8.5);
             Alumno a2 = new Alumno("Lucía", 20, "López Cerca", d2, 002, 9.5);
             Alumno a3 = new Alumno("Pepe", 18, "Sánchez Tierra", d3, 001, 7.5);
             Alumno a4 = new Alumno("Manuel", 30, "Lucas Marcos", d4, 004, 6.5);
             Profesor t = new Profesor("Luis", 40, "Matas Vera", d5, "DAM", 1199.99);

             p.SumarEdad();
             a.SumarEdad();
             t.SumarEdad();


             Console.WriteLine(p.ToString());
             Console.WriteLine(a.ToString());
             Console.WriteLine(t.ToString());


             Aula au = new Aula("Primero", t);

             /*Persona t2 = new Profesor();
             Persona al = new Alumno();

             au.P = ((Profesor)t2);
             au.Anadir((Alumno)al);

             au.Anadir(a);
             au.Anadir(a2);
             au.Anadir(a3);
             au.Anadir(a4);
             a.SumarEdad();

             au.Mostrar();


             au.Borrar(003);
             a.SumarEdad();

             au.Mostrar();

             au.Borrar(001);
             a.SumarEdad();

             au.Mostrar(); */

            Vista vista = new Vista();
            vista.Menu();


            Console.ReadLine();
        }


        

    }
}
