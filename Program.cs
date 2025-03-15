string timeDoCoracao = "Ny Yankees";
for (int i = 0; i < timeDoCoracao.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.White;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Blue;
    }
    Console.Write(timeDoCoracao[i]);
    Console.ResetColor();
}