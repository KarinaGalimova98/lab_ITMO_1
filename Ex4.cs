try
{
    Console.WriteLine("Please enter the first integer: ");
    int i = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter the second integer: ");
    int j = int.Parse(Console.ReadLine());

    int k = i / j;
    Console.WriteLine("The result is: " + k);
}
catch (FormatException e)
{
    Console.WriteLine("An format exception was thrown: {0}", e.Message);
}
catch (Exception e)
{
    Console.WriteLine("An exception was thrown: {0}", e.Message);
}

