
try
{
    Console.WriteLine("Informe o primeiro valor! ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Informe o segundo valor! ");
    int b = Convert.ToInt32(Console.ReadLine());

    int r = a / b;
    Console.WriteLine($"O resultado é {r}");
}

catch(DivideByZeroException e)
{
    Console.WriteLine($"Não é permitido divisão por zero! \n {e.Message}");
}

catch (FormatException e)
{
    Console.WriteLine($"Não é permitido divisão por letras! \n {e.Message}");
}

catch (Exception e)
{
    Console.WriteLine($"Ocorreu um erro! \n {e.Message}");
}
finally
{
    Console.WriteLine("Aqui passa de qualquer forma! ");
}
