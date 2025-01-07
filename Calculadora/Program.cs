float Numero1, Numero2 , adiçao , subtraçao , multiplicaçao , divisao , operaçoes;

Console.WriteLine("Tabelas de Operaçoes");
Console.WriteLine("1 Adição");
Console.WriteLine("2 Subtração");
Console.WriteLine("3 Divisão");
Console.WriteLine("4 Multiplcação");
operaçoes=float.Parse(Console.ReadLine());

    switch (operaçoes)
{
    case 1:
        Console.WriteLine("Digite o valor do Primeiro numero");
        Numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do Segundo numero");
        Numero2 = float.Parse(Console.ReadLine());

        adiçao= Numero1 + Numero2;

        Console.WriteLine("Resultado da adição: " + adiçao);
        break;

    case 2:
        Console.WriteLine("Digite o valor do Primeiro numero");
        Numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do Segundo numero");
        Numero2 = float.Parse(Console.ReadLine());

        subtraçao = Numero1 - Numero2;

        Console.WriteLine("Resultado da  subtração: " + subtraçao);
        break;

    case 3:
        Console.WriteLine("Digite o valor do Primeiro numero");
        Numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do Segundo numero");
        Numero2 = float.Parse(Console.ReadLine());

        divisao = Numero1 / Numero2;

        Console.WriteLine("Resultado da Divisão: " + divisao);
        break;

    case 4:
        Console.WriteLine("Digite o valor do Primeiro numero");
        Numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor do Segundo numero");
        Numero2 = float.Parse(Console.ReadLine());

        multiplicaçao = Numero1 * Numero2;

        Console.WriteLine("Resultado da Multiplacação: " + multiplicaçao);
        break;
}
Console.ReadKey();