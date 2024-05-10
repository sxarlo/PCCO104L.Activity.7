using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperCar Bugatti = new SuperCar(304, "Bugatti Chiron", "7 Speed");
            Bugatti.Super();

            SportsCar Porsche = new SportsCar(205, "Porsche 911 Carrera", "7 Speed");
            Porsche.Sports();

            FaveCar Lancer = new FaveCar(160, "Lancer Evo X", "6 Speed");
            Lancer.Fave();
        }
    }

    public class SuperCar
    {
        private string Car { get; set; }
        public string Speed { get; set; }
        private double Top { get; set; }

        public SuperCar() { }

        public SuperCar(double top)
        {
            Top = top;
        }
        public SuperCar(double top, string car) : this(top)
        {
            Car = car;
        }
        public SuperCar(double top, string car, string speed) : this(top, car)
        {
            Speed = speed;
        }

        public void Super()
        {
            Console.WriteLine($"{Speed} - {Car} - {Top} Top Speed");
        }
    }

    public class SportsCar
    {
        private string Car { get; set; }
        public string Speed { get; set; }
        private double Top { get; set; }

        public SportsCar() { }

        public SportsCar(double top)
        {
            Top = top;
        }
        public SportsCar(double top, string car) : this(top)
        {
            Car = car;
        }
        public SportsCar(double top, string car, string speed) : this(top, car)
        {
            Speed = speed;
        }

        public void Sports()
        {
            Console.WriteLine($"{Speed} - {Car} - {Top} Top Speed");
        }
    }

    public class FaveCar
    {
        private string Car { get; set; }
        public string Speed { get; set; }
        private double Top { get; set; }

        public FaveCar() { }

        public FaveCar(double top)
        {
            Top = top;
        }
        public FaveCar(double top, string car) : this(top)
        {
            Car = car;
        }
        public FaveCar(double top, string car, string speed) : this(top, car)
        {
            Speed = speed;
        }

        public void Fave()
        {
            Console.WriteLine($"{Speed} - {Car} - {Top} Top Speed");
        }
    }
}


