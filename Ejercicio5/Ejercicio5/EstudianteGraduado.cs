using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class EstudianteGraduado : Estudiante {

        // Atributos 
        private string Titutlo;

        // Constructor
        public EstudianteGraduado(string nombre, int edad, double calificacion, string titulo) : base(nombre, edad, calificacion) {
            Titutlo = titulo;
        }

        // Metodos 
        public string titulo {
            get { return Titutlo; }
            set { Titutlo = value; }
        }
    }
}
