using System;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;

namespace myProject
{
    class Shoes
    {
        private double _size;
        private string _color;
        private string _shoelery;
        private char _firstNameInitial;
        private char _lastNameInitial;

        public Shoes()
        {
            _size = 0.0;
            _color = "";
            _shoelery = "";
            _firstNameInitial = '\0';
            _lastNameInitial = '\0';
        }

        public Shoes(double size, string color, string design, char fInitial, char lInitial)
        {
            _size = size;
            _color = color;
            _shoelery = design;
            _firstNameInitial = fInitial;
            _lastNameInitial = lInitial;
        }

        public double GetSize()
        {
            return _size;
        }

        public string GetColor()
        {
            return _color;
        }

        public string GetShoelery()
        {
            return _shoelery;
        }

        public char GetFirstNameInitial()
        {
            return _firstNameInitial;
        }

        public char GetLastNameInitial()
        {
            return _lastNameInitial;
        }

        public void SetSize(double size)
        {
            _size = size;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public void SetShoelery(string design)
        {
            _shoelery = design;
        }

        public void SetFirstNameInitial(char fInitial)
        {
            _firstNameInitial = fInitial;
        }

        public void SetLastNameInitial(char lInitial)
        {
            _lastNameInitial = lInitial;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create your own custom shoes!");
            Shoes shoes1 = new Shoes();
            CustomShoes(shoes1);
            Shoes shoes2 = new Shoes();
            CustomShoes(shoes2);
            
            double size = 0.0;
            string color = "";
            string design = "";
            char fInitial = '\0';
            char lInitial = '\0';
            CustomShoes(ref size, ref color, ref design, ref fInitial, ref lInitial);
            Shoes shoes3 = new Shoes(size, color, design, fInitial, lInitial);
            CustomShoes(ref size, ref color, ref design, ref fInitial, ref lInitial);
            Shoes shoes4 = new Shoes(size, color, design, fInitial, lInitial);

            DesignReview(shoes1);
            DesignReview(shoes2);
            DesignReview(shoes3);
            DesignReview(shoes4);
        }

        static Shoes CustomShoes(Shoes s)
        {
            Console.WriteLine("What is your shoe size?");
            s.SetSize(double.Parse(Console.ReadLine()));
            Console.WriteLine("Choose the color for your custom shoes from the list below.\n[Pink, Red, White, Black, Orange, Purple, Yellow, Blue]");
            s.SetColor(Console.ReadLine());
            Console.WriteLine("Choose the design of the shoelery from below.\n[Logo, Rose, Star, Heart, Crown, Ribbon]");
            s.SetShoelery(Console.ReadLine());
            Console.WriteLine("What is the initial of your first name?");
            s.SetFirstNameInitial(char.Parse(Console.ReadLine()));
            Console.WriteLine("What is the initial of your last name?");
            s.SetLastNameInitial(char.Parse(Console.ReadLine()));
            return s;
        }

        static void CustomShoes(ref double size, ref string color, ref string design, ref char fInitial, ref char lInitial)
        {
            Console.WriteLine("What is your shoe size?");
            size = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose the color for your custom shoes from the list below.\n[Pink, Red, White, Black, Orange, Purple, Yellow, Blue]");
            color = Console.ReadLine();
            Console.WriteLine("Choose the design of the shoelery from below.\n[Logo, Rose, Star, Heart, Crown, Ribbon]");
            design = Console.ReadLine();
            Console.WriteLine("What is the initial of your first name?");
            fInitial = char.Parse(Console.ReadLine());
            Console.WriteLine("What is the initial of your last name?");
            lInitial = char.Parse(Console.ReadLine());
            return;
        }

        static void DesignReview(Shoes s)
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("Please review your design details.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Your shoe size: {s.GetSize()}");
            Console.WriteLine($"Shoes Color: {s.GetColor()}");
            Console.WriteLine($"Shoelery Design: {s.GetShoelery()}");
            Console.WriteLine($"Your Personalization:\n*** {s.GetFirstNameInitial()}.{s.GetLastNameInitial()} ***");
        }
    }
}
