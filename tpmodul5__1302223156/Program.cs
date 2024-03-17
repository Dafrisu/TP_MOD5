// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;


public class haloGeneric {

    public void sapaUser(string x) {
        Console.WriteLine("Halo User " + x);
    } 
}

class DataGeneric<T>
{
    public T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
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

        DataGeneric<string> dataString = new DataGeneric<string>("1302223156");
        dataString.PrintData();
    }
}