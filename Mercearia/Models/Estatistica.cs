namespace Models
{
    public class Estatistica
    {
        public double Ganhos { get; set; }
        public double Gastos { get; set; }
        public double Saldo { get { return Ganhos - Gastos; } }
    }
}
