using OtrasClases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clases.OtrasClases
{
    class Cliente : Persona 
    {
        public string telefono;

        public Cliente(string nombre, DateTime fechaNacimiento, string telefono)
        :base(nombre,fechaNacimiento){
            this.telefono = telefono;
        }
    }
}
