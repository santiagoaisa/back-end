using System;

namespace MisClases { 

class Moto : Vehiculo
	{

    protected string cilindrada;


    public Moto(string placa, EnumColores color, string numeroSerie,string cilindrada)
    :base(placa,color,numeroSerie) {
        this.cilindrada = cilindrada;
        
    }

}

}
