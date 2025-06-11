namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Implementado: obrigatoriedade de propriedade ao instanciar Iphone
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }
        // Implementado: sobrescrita do método InstalarAplicativo para Iphone
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando aplicativo {nomeApp} no Iphone... de modelo: {Modelo} e número: {Numero}");
        }
    }
}