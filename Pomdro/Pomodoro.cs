using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomdro
{
    internal class Pomdro
    {
        public int workTimer;
        public int restTimer;

        public void play()
        {
            Console.WriteLine("Please set work duration: ");
            var workInputTimer = Console.ReadLine();
            Console.WriteLine("Please set rest duration");
            var restInputTimer = Console.ReadLine();
            try
            {
                workTimer = Convert.ToInt32(workInputTimer);
                restTimer = Convert.ToInt32(restInputTimer);
                startWork();
                startRest();
            }
            catch
            {
                Console.WriteLine("wrong entry");
                play();
            }
        }
        
        public void startWork()
        {
            var workTime = new DateTime(2000, 1, 1, 0, workTimer, 0);

            for (int i = 0; i < workTimer * 60; i++)
            {
                Console.Write("Work Time Remains : {0}", workTime.ToString("mm:ss"));
                workTime = workTime.AddSeconds(-1);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

        public void startRest()
        {
            var restTime = new DateTime(2000, 1, 1, 0, restTimer, 0);
            for (int i = 0; i < workTimer * 60; i++)
            {
                Console.Write($"Rest Time Remains : {0}", restTime.ToString("mm:ss"));
                restTime = restTime.AddSeconds(-1);
                Thread.Sleep(1000);
                Console.Clear();
            }

        }
    }
}
