using System;

namespace cars
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("----------------------------------");

            Bmw a = new Bmw("sudan", "2020", "black");
                Console.WriteLine(a.type+"\n"+a.model+"\n"+a.color);
            Car.testing();
            Car.starting();
            Console.WriteLine("----------------------------------");
            Bmw b = new Bmw("Xfor", "2021", "red");
            Console.WriteLine(b.type +"\n"+b.model+"\n"+b.color);


            Car.testing();
            Car.starting();
            Console.WriteLine("------------------------------");

            Lexus c = new Lexus("460L", "2018", "selfr");
            Console.WriteLine(c.type+"\n"+c.model+"\n"+c.color);
            Car.testing();
            Car.starting();
            Console.WriteLine("------------------------------");

            Lexus f = new Lexus("jeep", "2022", "blue");
            Console.WriteLine(f.type + "\n" + f.model + "\n" + f.color);
            Car.testing();
            Car.starting();

        }
    }
}