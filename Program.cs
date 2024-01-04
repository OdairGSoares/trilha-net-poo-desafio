using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class Program
{
    static void Main(string[] args)
    {

        Iphone cell = new Iphone("1413514565", "Iphone 13", "12343-23534-645-23423", 12);
        cell.InstalarAplicativo("Pokemon GO");

        Nokia phone = new Nokia("1413514565", "Nokia", "12343-23534-645-23423", 12);
        phone.InstalarAplicativo("Mario Kart");
    }
}