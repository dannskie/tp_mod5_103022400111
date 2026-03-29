using System;

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;   
    }
    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + this.data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataGeneric<string> nim = new DataGeneric<string>("103022400111");
        nim.PrintData();
    }
}
