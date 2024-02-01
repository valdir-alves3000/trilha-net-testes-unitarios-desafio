namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        public int RetornarQuantidadeCaracteres(string texto)
        {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }

        public bool ContemCaractere(string texto, string textoProcurado)
        {
            var contem = texto.Contains(textoProcurado);
            return contem;
        }

        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }

        public string InverterTexto(string texto)
        {
            string stringInvertida = "";
            for (int i = texto.Length - 1; i >= 0; i--) stringInvertida += texto[i];

            // char[] charArray = texto.ToCharArray();
            // Array.Reverse(charArray);
            // string stringInvertida = new string(charArray);

            return stringInvertida;
        }
    }
}