using System;
using System.Globalization;
using System.Text;

namespace Biblioteca
{
    public static class Ferramentas
    {
        public static void print(dynamic texto = null)
        {
            if (texto != null) Console.WriteLine(texto);
            else Console.WriteLine();
        }
        public static void print_(dynamic texto)
        {
            Console.Write(texto);
        }


        public static string RemoverAcentos(string texto)
        {
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);nvolvimento
            StringBuilder resultado = new StringBuilder();

            foreach (char letra in textoNormalizado)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letra) != UnicodeCategory.NonSpacingMark)
                {
                    resultado.Append(letra);
                }
            }

            return resultado.ToString().Normalize(NormalizationForm.FormC);
        }


        public static void ColorLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
        public static void ColorBack(string text, ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
