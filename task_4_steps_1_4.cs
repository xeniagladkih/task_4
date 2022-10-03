using System;

namespace ConsoleApp3
{
    abstract class GObject
    {
        private string X = " ";
        private string Y = " ";
        private string Name = " ";
        private string Description = " ";
        public string GetX
        {
            get { return X; }
            set { X = value; }
        }
        public string GetY
        {
            get { return Y; }
            set { Y = value; }
        }
        public string GetName
        {
            get { return Name; }
            set { Name = value; }
        }
        public string GetDescription
        {
            get { return Description; }
            set { Description = value; }
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("*Information about the geographical object");
        }
    }

    class River : GObject
    {
        private double Speed;
        private double Length;
        public double GetSpeed
        {
            get { return Speed; }
            set { Speed = value; }
        }
        public double GetLength
        {
            get { return Length; }
            set { Length = value; }
        }
        public override void GetInfo()
        {
            Console.WriteLine("*Information about the river");
            //base.GetInfo();
        }
    }

    class Mount : GObject
    {
        private double HPick;
        public double GetHPick
        {
            get { return HPick; }
            set { HPick = value; }
        }
        public override void GetInfo()
        {
            Console.WriteLine("*Information about the mount");
            base.GetInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            River river = new()
            {
                GetName = "Dnipro",
                GetDescription = "The Dnipro is a typical plain river with a slow and calm flow.",
                GetSpeed = 120,
                GetLength = 2200
            };
            Console.WriteLine(river.GetName + System.Environment.NewLine);
            Console.WriteLine(river.GetDescription);
            river.GetInfo();
            Console.WriteLine("Dnipro's speed is " + river.GetSpeed + " smps");
            Console.WriteLine("Dnipro's length is " + river.GetLength + " km");
        }
    }
}
