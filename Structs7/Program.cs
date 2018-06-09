using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs7
{
    struct Train: IComparable
    {
        public string name;
        public int numberOfTrain;
        public string startTime;

        public Train(string name, int numberOfTrain, string startTime)
        {
            this.name = name;
            this.numberOfTrain = numberOfTrain;
            this.startTime = startTime;
        }

        public int CompareTo(object obj)
        {
            Train t = (Train)obj;
            return numberOfTrain.CompareTo(t.numberOfTrain);
        }

        public void Show()
        {
            Console.WriteLine(name);
            Console.WriteLine(numberOfTrain);
            Console.WriteLine(startTime);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Train[] trs = new Train[3];
            for (int i = 0; i < trs.Length; i++)
            {
                string name, time;
                int number;
                Console.Write("Enter name: ");
                name = Console.ReadLine();
                Console.Write("Enter number: ");
                number = int.Parse(Console.ReadLine());
                Console.Write("Enter start time: ");
                time = Console.ReadLine();
                trs[i] = new Train(name, number, time);
            }

            Array.Sort(trs);

            int num;
            Console.Write("Enter number of train: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < trs.Length; i++)
                if (trs[i].numberOfTrain == num)
                    trs[i].Show();
            
            Console.ReadLine();
        }
    }
}
