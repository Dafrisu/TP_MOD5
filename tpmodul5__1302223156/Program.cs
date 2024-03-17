// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;


public class haloGeneric {

    public void sapaUser(string x) {
        Console.WriteLine("Halo User " + x);
    } 
}

class program()
{
    static void Main(string[] args)
    {
        String a;
        haloGeneric inputUser = new haloGeneric();
        Console.WriteLine("Input: ");
        a=Console.ReadLine();
        inputUser.sapaUser(a);
    }
}