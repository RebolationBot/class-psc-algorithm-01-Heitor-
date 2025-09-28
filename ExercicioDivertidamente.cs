using System;

class Program
{
    static void Main(string[] args)
    {
        int amizades, exercicios, naoFeitos;
        int alegria = 0, tristeza = 0;
        double A1, A2, A3, media;

        Console.WriteLine("=== Experiência da Riley na nova cidade ===\n");

        // --- Amizades ---
        Console.Write("Riley fez novas amizades na cidade? Se sim, digite quantas (0 se nenhuma): ");
        amizades = Convert.ToInt32(Console.ReadLine());

        if (amizades > 0)
        {
            alegria += amizades * 10;
        }
        else
        {
            tristeza += 30;
        }

        // --- Provas ---
        Console.Write("Digite a nota da prova A1 (0 a 10): ");
        A1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota da prova A2 (0 a 10): ");
        A2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a nota da prova A3 (0 a 10): ");
        A3 = Convert.ToDouble(Console.ReadLine());

        media = (A1 + A2 + A3) / 3.0;

        if (media >= 7)
        {
            alegria += 50;
        }
        else
        {
            tristeza += 50;
        }

        // --- Exercícios de programação ---
        Console.Write("Riley conseguiu resolver quantos exercícios de programação? (0 a 10): ");
        exercicios = Convert.ToInt32(Console.ReadLine());

        // validação simples
        if (exercicios < 0) exercicios = 0;
        if (exercicios > 10) exercicios = 10;

        naoFeitos = 10 - exercicios;
        alegria += exercicios * 10;
        tristeza += naoFeitos * 10;

        // --- Resultados ---
        Console.WriteLine("\n--- Pontuações ---");
        Console.WriteLine($"Alegria: {alegria}");
        Console.WriteLine($"Tristeza: {tristeza}");
        Console.WriteLine($"Média das provas: {media:F2}");

        if (alegria > tristeza)
        {
            Console.WriteLine("\nA mudança para a nova cidade foi uma experiência incrível para a Riley.");
        }
        else
        {
            Console.WriteLine("\nA mudança para a nova cidade foi uma experiência desagradável para a Riley.");
        }
    }
}
