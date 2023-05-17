class Program
{
static void Main()
{
    uint? edad=null;
    Console.WriteLine("captura tu edad y presiona <Enter>");
    String? edadCapturada=Console.ReadLine();
    if(edadCapturada is not null)
    {
        try
        {
            edad=uint.Parse(edadCapturada);
        }
        catch(FormatException)
        {
Console.WriteLine("El formato es incorrecta");
        }
        catch (StackOverflowException)
        {
            Console.WriteLine("El numero ingresado es muy grande");
        }

    }
    if(edad is not null )
    Console.WriteLine($"Tu edad es:{edad}");
    else
    Console.WriteLine($"No se ha capturado una edad valida");

    

    Console.WriteLine($"Tu edad es: {edad}");


}
}

