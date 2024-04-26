namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set;}
        private string Modelo {get; set;}
        private string IMEI {get; set;} 
        private int Memoria{get; set;}

        public Smartphone(string numero, string modelo, string IMEI, int Modelo)
        {
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = IMEI;
            this.Memoria = Memoria;
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