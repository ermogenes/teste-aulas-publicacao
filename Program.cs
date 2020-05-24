using System;
using Figgle;

namespace teste_aulas_publicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(FiggleFonts.Ivrit.Render("Obrigado,"));
            Console.WriteLine(FiggleFonts.Crazy.Render("Dev C# !"));
            Console.ResetColor();
            Console.Write("Pressione uma tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
