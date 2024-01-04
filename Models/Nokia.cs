namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public double nomeApp  { get; set; } 
        public Nokia(string Numero, string Modelo, string IMEI, int Memoria) : base(Numero,Modelo,IMEI,Memoria)
        {


        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        override public void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Aplicativo {nomeApp} instalado!");
        }
    }
}