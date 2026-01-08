using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public interface ICar
    {
        void Moving();
        void TurnRight();
        void TurnLeft();
        void Stop();
    }

    public abstract class Car : ICar
    {
        private string color;
        private int numberofseats;
        public int model;
        public string size;

        public void SetColor(string C)
        {
            this.color = C;
        }
        public string GetColor()
        {
            return this.color;
        }
        public void SetNumberOfSeats(int N)
        {
            this.numberofseats = N;
        }
        public int GetNumberOfSeats()
        {
            return this.numberofseats;
        }

        public abstract void Moving();
        public abstract void TurnRight();
        public abstract void TurnLeft();
        public abstract void Stop();
    }

    public class Hatchback : Car
    {
        public override void Moving()
        {
            Console.WriteLine("The Car is Moving.");
        }
        public override void TurnRight()
        {
            Console.WriteLine("The Car is turning right.");
        }
        public override void TurnLeft()
        {
            Console.WriteLine("The Car is turning left.");
        }
        public override void Stop()
        {
            Console.WriteLine("The Car is Stopping.");
        }
        public void Price(int model)
        {
            if (model >= 2015)
                Console.WriteLine("The Price is 300000");
            else
                Console.WriteLine("The Price is 200000");
        }
        public void Speed(int model)
        {
            if (model >= 2015)
                Console.WriteLine("The Speed is 600");
            else
                Console.WriteLine("The Price is 400");
        }
    }

    public class Sedan : Car
    {
        public override void Moving()
        {
            Console.WriteLine("The Car is Moving.");
        }
        public override void TurnRight()
        {
            Console.WriteLine("The Car is turning right.");
        }
        public override void TurnLeft()
        {
            Console.WriteLine("The Car is turning left.");
        }
        public override void Stop()
        {
            Console.WriteLine("The Car is Stopping.");
        }
        public void Price(int model)
        {
            if (model >= 2015)
                Console.WriteLine("The Price is 400000");
            else
                Console.WriteLine("The Price is 150000");
        }
        public void Speed(int model)
        {
            if (model >= 2015)
                Console.WriteLine("The Speed is 800");
            else
                Console.WriteLine("The Price is 600");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Hatchback h1 = new Hatchback();
            h1.SetColor("black");
            Console.WriteLine(h1.GetColor());
            h1.SetNumberOfSeats(4);
            Console.WriteLine(h1.GetNumberOfSeats());
            h1.model = 2017;
            h1.size = "medium";
            h1.Moving();
            h1.TurnRight();
            h1.TurnLeft();
            h1.Stop();
            h1.Price(2017);
            h1.Speed(2017);

            Sedan s1 = new Sedan();
            s1.SetColor("white");
            Console.WriteLine(s1.GetColor());
            s1.SetNumberOfSeats(4);
            Console.WriteLine(s1.GetNumberOfSeats());
            s1.model = 2012;
            s1.size = "large";
            s1.Moving();
            s1.TurnRight();
            s1.TurnLeft();
            s1.Stop();
            s1.Price(2012);
            s1.Speed(2012);
        }
    }
}


