using System;

namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia, que chama o construtor da classe base (Smartphone)
        public Nokia(string numero, string imei, string modelo, int memoria)
            : base(numero, imei, modelo, memoria)
        {
            // Lógica específica para a classe Nokia pode ser adicionada aqui, se necessário
        }

        // Sobrescreve o método da classe base
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia...");
        }

        // Métodos adicionais específicos para a classe Nokia podem ser adicionados aqui
    }
}
