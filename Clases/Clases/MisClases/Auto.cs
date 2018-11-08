namespace MisClases
{

    class Auto : Vehiculo
    {

        protected string cilindrada;

        public Auto(String placa, EnumColores color, String numeroSerie, String cilindrada)
        : base(placa, color, numeroSerie)
        {
            this.cilindrada = cilindrada;
        }



    }


}
