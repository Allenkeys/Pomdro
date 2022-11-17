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
        public List<string> worktimeLog = new List<string>();

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
            DateTime workStartTime = DateTime.Now;
            worktimeLog.Add(Convert.ToString("Work start instance: " + workStartTime));

            for (int i = 0; i < workTimer * 60; i++)
            {
                Console.Write("Work Time Remains : {0}", workTime.ToString("mm:ss"));
                workTime = workTime.AddSeconds(-1);
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.Beep(2000, 1000);
            DateTime workEndTime = DateTime.Now;
            worktimeLog.Add(Convert.ToString("Work end instance: " + workEndTime));
        }

        public void startRest()
        {
            DateTime restStartTime = DateTime.Now;
            worktimeLog.Add(Convert.ToString("Rest start instance: " + restStartTime));
            var restTime = new DateTime(2000, 1, 1, 0, restTimer, 0);
            for (int i = 0; i < restTimer * 60; i++)
            {
                Console.Write("Rest Time Remains : {0}", restTime.ToString("mm:ss"));
                restTime = restTime.AddSeconds(-1);
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("Work time ended, time to rest...");   
            Console.Beep(3000, 1000);
            DateTime restEndTime = DateTime.Now;
            worktimeLog.Add(Convert.ToString("Rest end instance: " + restEndTime));
        }

        public void getWorkLog()
        {
            foreach(var workLog in worktimeLog)
            {
                Console.WriteLine("=================================");
                Console.WriteLine(workLog);
            }
        }

        public void controller()
        {
            bool isActive = true;
          
            while (isActive)
            {
                for (int i = 0; i < 3; i++)
                {
                    startWork();
                    startRest();
                }

                isActive = false;
            }
            getWorkLog();   
        }
    }
}
