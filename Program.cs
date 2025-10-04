string frase;


Console.WriteLine("Digite uma frase: ");


frase = Console.ReadLine()!;


Console.WriteLine(
    frase.Replace("rr", "l")
         .Replace("RR", "L")
         .Replace("r", "l")
         .Replace("R", "L")
);
