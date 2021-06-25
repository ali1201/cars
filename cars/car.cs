namespace cars
{

    class Car
    {
        public string type;
        public string model;
        public string color;

        public  Car(string a , string b , string c)
        {
            type  =  a;
            model =  b;
            color =  c;
        }
        public void Cartype()
        {
            System.Console.WriteLine($"car type is : {type}");
            System.Console.WriteLine($"car model is : {model}");
            System.Console.WriteLine($"car color is : {color}");
        }
        public static void testing()
        {
            System.Console.WriteLine("teesting......");
        }
        public static void starting()
        {
            System.Console.WriteLine("starting.....");
        }
    }

    









}

