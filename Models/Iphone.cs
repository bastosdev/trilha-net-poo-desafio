namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        public override void Ligar()
        {
            Console.WriteLine("Ligando....");
            Console.WriteLine("Bem-vindo ao seu novo Iphone");
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Intalando o aplicativo "+ nomeApp +" no Iphone ");
        }
    }
}