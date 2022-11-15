namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo {get;}
        private string IMEI {get;}
        private int Memoria {get;}

        public Smartphone(string numero, string modelo, string IMEI, int memoria)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = IMEI;            
            this.Memoria = memoria;
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