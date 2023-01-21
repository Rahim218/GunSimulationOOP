using System;

namespace GunSimulationOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automat automat = new Automat(5.56, "Blue", "Ak-47");
            automat.Shoot(1);
            automat.Reloat(2);
            automat.Voice();
            Console.WriteLine(automat.GunCount=25);


        }
        static int SumEvenNumbers(int num)
        {
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        static void SumEvenNumber(int num)
        {
            Console.WriteLine(SumEvenNumbers(num));
        }
        static int SameWord(string sentece)
        {
            int count = 1;
            for (int i = 0; i < sentece.Length; i++)
            {
                if (sentece[i] == ' ')
                {
                    count++;
                }
            }
            string[] words = new string[count];
            string newStr = " ";
            int counts = 0;
            for (int j = 0; j < sentece.Length; j++)
            {

                if (sentece[j] != ' ')
                {
                    newStr += sentece[j];
                }
                else
                {
                    words[counts] = newStr;
                    counts++;
                    newStr = " ";
                }

            }
            words[counts] = newStr;
            int counter = 1;
            for (int m = 0; m < words.Length; m++)
            {
                for (int n = m + 1; n < words.Length; n++)
                {
                    if (words[m] == words[n])
                    {
                        counter++;
                        m = n;
                    }
                }
            }
            return counter;
        }
    }
    public class Gun
    {
        public string color;
        public string model;
        private int gunCount;
        public double typeOfGun;
        public Gun(double typeOfGun, string color, string model)
        {
            this.color = color;
            this.model = model;
            this.gunCount = gunCount;

        }
        public virtual int GunCount
        {
            set
            {
                if (value < 30)
                {
                    Console.WriteLine("Gulle sayisi azdi");
                }
            }
            get
            {
                return this.gunCount;
            }

        }

        public void Reloat(int number)
        {
            if (number == 1)
            {
                Console.WriteLine("Gulle bir basa dolduruldu");
            }
            else if (number == 2)
            {
                Console.WriteLine("Gulle bir bir doldurulur");
            }
        }
        public void Shoot(int number)
        {
            if (number == 1)
            {
                Console.WriteLine("Silah auto rejimindedir");
            }
            else if (number == 2)
            {
                Console.WriteLine("Silah tekli rejimdedir");
            }

        }
        public virtual void Voice()
        {
            Console.WriteLine("Silah sesi");
        }
    }
    public class Automat : Gun
    {
        public Automat(double typeOfGun, string color, string model) : base(typeOfGun, color, model )
        {

        }
        public override void Voice()
        {
            Console.WriteLine($"{model} sesi");
        }
        public override int GunCount { get => base.GunCount; set => base.GunCount = value; }

    }
    public class Pistol : Gun
    {
        public Pistol(double typeOfGun, string color, string model) : base(typeOfGun, color, model)
        {

        }
        public override int GunCount
        {
            set
            {
                if (value<15)
                {
                    Console.WriteLine("Gulle sayini artirin");
                }
            }
            get
            {
                return GunCount;
            }
        }
    }
}
