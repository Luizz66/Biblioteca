using System;
using System.Globalization;
using System.Text;

namespace Biblioteca
{
    public static class Ferramentas
    {
        public static void print(dynamic txt = null)
        {
            if (txt != null) Console.WriteLine(txt);
            else Console.WriteLine();
        }
        public static void print_(dynamic txt)
        {
            Console.Write(txt);
        }


        public static string RemoverAcentos(string txt)
        {
            string txtNormalizado = txt.Normalize(NormalizationForm.FormD);
            StringBuilder resultado = new StringBuilder();

            foreach (char letra in txtNormalizado)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letra) != UnicodeCategory.NonSpacingMark)
                {
                    resultado.Append(letra);
                }
            }

            return resultado.ToString().Normalize(NormalizationForm.FormC);
        }


        public static void ColorLine(string txt, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(txt);
            Console.ResetColor();
        }
        public static void ColorBack(string txt, ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.Write(txt);
            Console.ResetColor();
        }
    }
}
