namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Imei { get; }
        public string Modelo { get; }
        public int Memoria { get; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string imei, string modelo, int memoria)
        {
            Numero = numero;
            Imei = imei;
            Modelo = modelo;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}