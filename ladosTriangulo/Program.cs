double ladoA, ladoB, ladoC;

Console.Write("Digite o valor do lado A: ");
ladoA = double.Parse(Console.ReadLine());

Console.Write("Digite o valor do lado B: ");
ladoB = double.Parse(Console.ReadLine());

Console.Write("Digite o valor do lado C: ");
ladoC = double.Parse(Console.ReadLine());

// verificação do tipo de triângulo
if (ladoA == ladoB && ladoB == ladoC) // triângulo equilátero
    {
        Console.WriteLine("O triângulo é equilátero.");
    }
else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC) // triângulo isósceles
    {
        Console.WriteLine("O triângulo é isósceles.");
    }
else // triângulo escaleno
    {
        Console.WriteLine("O triângulo é escaleno.");
    }
