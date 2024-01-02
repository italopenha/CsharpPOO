namespace Exe06
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public string Resultado;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public void AprovadoOuReprovado()
        {
            if (NotaFinal() >= 60)
                Resultado = "APROVADO";
            else
                Resultado = "REPROVADO";
        }

        public override string ToString()
        {
            return $"NOTA FINAL = {NotaFinal():F2}\n{Resultado}";
        }
    }
}
