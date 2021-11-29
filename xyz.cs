using System;

abstract class Animal
{
    abstract public void Breath();
}

class Ssak : Animal
{
    public override void Breath()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Stos - Obszar pamięci komputera, który alokowany jest w momęcie uruchamiania programu. System operacyjny musi wtedy ocenić ile pamięci potrzeba do prawidłowego działania programu...");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Sterta - Obszar pamięci operacyjnej dostępnej w trakcie działania programu...:)");
    }
}

static class boo
{
    static public int Ee;
    static public int E
    {
        get
        {
            return Ee ;
        }
        set
        {
            Ee = value;
        }
    }
}

class Program
{

    static void Main(string[] args)
    {

        boo.E = 5;
        Console.WriteLine(boo.Ee + boo.E);

        Animal MyAnimal = new Ssak();
        MyAnimal.Breath();
        Console.ReadLine();
    }
}