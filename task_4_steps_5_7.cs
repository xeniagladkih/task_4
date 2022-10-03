using System;
using System.Drawing;

namespace ConsoleApp4
{
    public interface IGObject
    {
        void GetX();
        void GetY();
        void GetName();
        void GetDescription();
        void GetInfo();
    }

    public class River : IGObject
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
        public void GetInfo()
        {
            Console.WriteLine("*Information about the river");
        }
        public void GetName()
        {
            Console.WriteLine("Amazon River" + System.Environment.NewLine);
        }
        public void GetDescription()
        {
            Console.WriteLine("*Description about the river");
        }
        public void GetX()
        {
            Console.WriteLine("Coordinate X is 15°31" + (char)39 + "04" + (char)34 + "S");
        }
        public void GetY()
        {
            Console.WriteLine("Coordinate Y is 71°41" + (char)39 + "37" + (char)34 + "W");
        }
    }

    public class Mount : IGObject
    {
        private double HPick;
        public double GetHPick
        {
            get { return HPick; }
            set { HPick = value; }
        }
        public void GetInfo()
        {
            Console.WriteLine("Information about the Mount");
        }
        public void GetName()
        {
            Console.WriteLine("Mount Everest" + System.Environment.NewLine);
        }
        public void GetDescription()
        {
            Console.WriteLine("Description about the mount");
        }
        public void GetX()
        {
            Console.WriteLine("Coordinate X is 27°59" + (char)39 + "17" + (char)34 + "N");
        }
        public void GetY()
        {
            Console.WriteLine("Coordinate Y is 86°55" + (char)39 + "31" + (char)34 + "E");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
           
            River river = new()
            {
                GetSpeed = 5,
                GetLength = 6500
            };
            
            river.GetName();
            river.GetX();
            river.GetY();
            river.GetDescription();
            river.GetInfo();

            Console.WriteLine("Amazonka's speed is " + river.GetSpeed + " mps");
            Console.WriteLine("Amazonka's length is " + river.GetLength + " m");
        }
    }
}


