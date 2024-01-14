using System;

namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone, que chama o construtor da classe base (Smartphone)
        public Iphone(string numero, string imei, string modelo, int memoria)
            : base(numero, imei, modelo, memoria)
        {
            // Lógica específica para a classe Iphone pode ser adicionada aqui, se necessário
        }

        // Sobrescreve o método da classe base
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone...");
        }

        // Métodos adicionais específicos para a classe Iphone podem ser adicionados aqui
    }
}
