using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioAC
{
    public class Vista { 

    private Aula aula;

    public Vista() { 
     aula= new Aula();
    
    }

        public void Menu() { 

        Aula au = new Aula();
    
        Console.WriteLine("Introduce la opcion que deseas hacer:");
        Console.WriteLine("1 crear un aula nueva");
        Console.WriteLine("2 para añadir un alumno.");
        Console.WriteLine("3 para borrar un alumno.");
        Console.WriteLine("4 para mostrar los alumnos.");
        Console.WriteLine("5 para mostrar el aula completa.");
        Console.WriteLine("0 para salir.");
        string input = Console.ReadLine();
        int opcion = Int32.Parse(input);
        
        while(opcion!=0){
             
             switch(opcion){
                 case 1:
                  
                  Console.WriteLine("Introduce el nombre del aula");
                  string nombre= Console.ReadLine();
                  Console.WriteLine("Introduce el nombre del profesor");
                  string nprofe = Console.ReadLine();
                  Console.WriteLine("Introduce la edad del profesor");
                  input = Console.ReadLine();
                  int eprofe = Int32.Parse(input);
                  Console.WriteLine("Introduce los apellidos del profesor");
                  string aprofe = Console.ReadLine();
                  Console.WriteLine("Introduce el número de DNI del profesor");
                  input = Console.ReadLine();
                  int dprofe = Int32.Parse(input);
                  Dni dni = new Dni(dprofe);
                  Console.WriteLine("Introduce la titulación del profesor");
                  string tprofe = Console.ReadLine();
                  Console.WriteLine("Introduce el salario del profesor");
                  input = Console.ReadLine();
                  double sprofe = double.Parse(input);
                  Profesor profe = new Profesor(nprofe, eprofe, aprofe, dni, tprofe, sprofe);
                  au = new Aula(nombre, profe);
                        
                 break;
                 case 2:

                  Console.WriteLine("Introduce el nombre del alumno");
                  string nalum = Console.ReadLine();
                  Console.WriteLine("Introduce la edad del alumno");
                  input = Console.ReadLine();
                  int ealum = Int32.Parse(input);
                  Console.WriteLine("Introduce los apellidos del alumno");
                  string apealum = Console.ReadLine();
                  Console.WriteLine("Introduce el número de DNI del alumno");
                  input = Console.ReadLine();
                  int dalum = Int32.Parse(input);
                  dni = new Dni(dalum);
                  Console.WriteLine("Introduce el Id del alumno");
                  input = Console.ReadLine();
                  int idalum = Int32.Parse(input);
                  Console.WriteLine("Introduce la media del alumno");
                  input = Console.ReadLine();
                  double medalum = double.Parse(input);
                  Alumno alum = new Alumno(nalum, ealum, apealum, dni, idalum, medalum);
                  au.Anadir(alum);

                 break;
                 case 3:
                        Console.WriteLine("Introduce el Id del alumno a borrar");
                        input = Console.ReadLine();
                        idalum = Int32.Parse(input);
                        au.Borrar(idalum);

                        break;
                 case 4:

                        au.Mostrar();
 

                 break;
                 case 5:

                        au.MostrarAula();

                 break;
                
                 default:
                     Console.WriteLine("No has introducido una opción válida");
                 break;                
            }

                Console.WriteLine("Introduce la opcion que deseas hacer:");
                Console.WriteLine("1 crear un aula nueva");
                Console.WriteLine("2 para añadir un alumno.");
                Console.WriteLine("3 para borrar un alumno.");
                Console.WriteLine("4 para mostrar los alumnos.");
                Console.WriteLine("5 para mostrar el aula completa.");
                Console.WriteLine("0 para salir.");
                input = Console.ReadLine();
                opcion = Int32.Parse(input);
            }

            Console.WriteLine("¡Gracias por usar nuestra aplicación!");


        }

    }
     
    
}


