namespace Exe04
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return Largura * 2 + Altura * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString()
        {
            return $"ÁREA = {Area():F2}\nPERÍMETRO = {Perimetro():F2}\nDIAGONAL = {Diagonal():F2}";
        }
    }
}
