string frase, ceboles;

Console.Write("Escreva uma frase: ");
frase = Console.ReadLine()!;
ceboles =  frase
.Replace("r", "l")
.Replace("R", "L");
Console.WriteLine(ceboles);


