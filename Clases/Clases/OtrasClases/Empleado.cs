using OtrasClases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clases.OtrasClases
{
    class Empleado : Persona 
    {
        public double sueldo;

        public Empleado(string nombre, DateTime fechaNacimiento,  double sueldo)
        :base(nombre,fechaNacimiento){
            this.sueldo = sueldo;
        }

        public void AsignarSueldo(double sueldo)
        {
            this.sueldo = sueldo;

        }
    }

   

}
