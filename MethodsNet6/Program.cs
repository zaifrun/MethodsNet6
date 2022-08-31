// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World from main program!");

//kode her bla bla
TestMethod(); //kald af en metode
int resultat = MyMethods.Gange(3, 4);
Console.WriteLine("Resultat: "+resultat);

//Alle metoder skal ligge til sidst i koden.
//De kan også pakkes ind i en klasse, hvis man vil

    void TestMethod()
    {
        Console.WriteLine("Hello World from a method!");
    }

public class MyMethods
{
    public static int Gange(int tal1, int tal2)
    {
        //returneringsværdien skal matche 
        //den returværdi signaturen indeholder
        return tal1 * tal2;
    }

    /* flere metoder her....*/
}

