using System;

namespace ConsoleApp_ObjectAndClass
{
    class Program
    {
        int id;
        String name;

        public void insert(int i, String n)
        {
            id = i;
            name = n;
        }

        public void display()
        {
            Console.WriteLine("Edad: " + id + " Nombre: " + name);
        }

        static void Main(string[] args)
        {
            Program s1 = new Program();

            s1.id = 27;
            s1.name = "Deni Zelaya";

            Console.WriteLine(s1.id);
            Console.WriteLine(s1.name);

            Program s2 = new Program();
            s2.insert(27, "Denis Federico");
            s2.display();
        }
    }
}
