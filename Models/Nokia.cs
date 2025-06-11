namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Implementado: obrigatoriedade de propriedade ao instanciar Nokia
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) { }
        // Implementado: sobrescrita do método InstalarAplicativo para Nokia
        public override void InstalarAplicativo(string nomeApp)
        {
            System.Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia... de modelo: {Modelo} e número: {Numero}");
        }
    }
}