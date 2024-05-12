namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}
        
        public override void Ligar()
        {
            Console.WriteLine("Ligando...");
            Console.WriteLine("Bem-vindo ao seu novo Nokia");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Intalando o aplicativo "+ nomeApp +" no Nokia ");
        }
    }
}