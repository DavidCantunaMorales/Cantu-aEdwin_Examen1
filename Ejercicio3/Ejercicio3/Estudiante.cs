using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio3 {
    internal class Estudiante {

        // Atributos
        private string Nombre;
        private int Edad;
        private double Calificacion;
    
        // Constructor 
        public Estudiante(string nombre, int edad, double calificacion){
            Nombre = nombre;
            Edad = edad;
            Calificacion = calificacion;
        }

        // Metodos 
        public string nombre {
            get { return Nombre; }
            set { Nombre = value; }

        }

        public int edad {
            get { return Edad; }
            set { Edad = value; }
        }

        public double calificacion {
            get { return Calificacion; }
            set { Calificacion = value; }
        }
    }
}
