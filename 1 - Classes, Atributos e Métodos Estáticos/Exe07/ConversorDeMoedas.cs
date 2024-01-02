namespace Exe07
{
    internal class ConversorDeMoedas
    {
        public static double Iof = 0.06;

        public static double Converter(double cotacao, double dolares)
        {
            double conversao = cotacao * dolares;
            double iof = conversao * Iof;
            return conversao + iof;
        }
    }
}
