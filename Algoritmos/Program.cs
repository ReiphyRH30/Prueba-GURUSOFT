
class Program
{
    static string GenerateOutput(string datoDeEntrada)
    {       
        var indexHome = datoDeEntrada.Length / 2;
        var length = datoDeEntrada.Length % 2 == 0 ? 2 : 1;

        return datoDeEntrada.Substring(indexHome - length / 2, length);
    }

    static void Main()
    {
        string datoDeEntrada1 = "jafgyA";
        string datoDeEntrada2 = "Qc1uoTgfd";
        string datoDeEntrada3 = "n3urcaVsw4r7";
        string datoDeEntrada4 = "iO4L";
        string datoDeEntrada5 = "GsF";

        string datoDeEntrada6 = "abcdefgh";

        Console.WriteLine(GenerateOutput(datoDeEntrada1));
        Console.WriteLine(GenerateOutput(datoDeEntrada2));
        Console.WriteLine(GenerateOutput(datoDeEntrada3));
        Console.WriteLine(GenerateOutput(datoDeEntrada4));
        Console.WriteLine(GenerateOutput(datoDeEntrada5));
        Console.WriteLine(GenerateOutput(datoDeEntrada6));
    }
}
