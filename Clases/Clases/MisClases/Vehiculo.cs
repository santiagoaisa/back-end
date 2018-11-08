namespace MisClases { 

class Vehiculo
{
    public String placa;
    public EnumColores color;
    public String numeroSerie;
    public EnumEstado estado;

   

    public Vehiculo(String placa, EnumColores color, String numeroSerie)
    {
        this.placa = placa;
        this.color = color;
        this.numeroSerie = numeroSerie;
        this.estado = EnumEstado.APAGADO;
        


    }


    public void Encender()
    {

        if (this.estado==EnumEstado.APAGADO)
        {
            this.estado = EnumEstado.ENCENDIDO;
            return "Vehiculo Encendido";
        }
        else
        {

            return $"El Vehiculo es {this.estado}";
        }

    }

    public void Frenar()
    {
        if (this.estado == EnumEstado.ENMARCHA)
        {
            this.estado = EnumEstado.DETENIDO;
            return "Vehiculo Detenido";
        }
    }

    public void Girar(EnumDireccion direccion)
    {        
            this.estado = direccion;
            return $"Vehiculo esta a {direccion}";
        
    }
}


}