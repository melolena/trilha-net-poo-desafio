namespace DesafioPOO.Models
{
    // finalizado
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){

        }
        // finalizado
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{nomeApp} instalado com sucesso! - Nokia");
        }
    }
}