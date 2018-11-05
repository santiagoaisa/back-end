namespace MisClases { 

class Moto : Vehiculo
	{

    protected string cilindrada;


    public Moto(String placa, EnumColores color, String numeroSerie,String cilindrada)
    :base(placa,color,numeroSerie) {
        this.cilindrada = cilindrada;
        
    }

}

}
