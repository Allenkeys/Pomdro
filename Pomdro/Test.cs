using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomdro
{
    internal class Tester
    {
        private int _workDuration;
        private int _restDuration;

        public void PomodoroRule()
        {
            Console.WriteLine("Enter Work Duration In Minutes");
            var workDurationInput = Console.ReadLine();
            Console.WriteLine("Enter Rest Duration In Minutes");
            var restDurationInput = Console.ReadLine();
            Tester test = new();

            if (int.TryParse(workDurationInput, out test._workDuration) && int.TryParse(restDurationInput, out test._restDuration))

            {


                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.CursorVisible = false;
                var workTime = new DateTime(2000, 1, 1, 0, test._workDuration, 0);
                var restTime = new DateTime(2000, 1, 1, 0, test._restDuration, 0);


                void WorkPomodoro()
                {
                    DateTime WorkStartTime = DateTime.Now;
                    for (int i = 0; i <= test._workDuration * 60; i++)
                    {
                        Console.Write("Work Time Remains : {0}", workTime.ToString("mm:ss"));
                        workTime = workTime.AddSeconds(-1);
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                    DateTime WorkStopTime = DateTime.Now;
                    Console.WriteLine("Work Time Over");
                    Console.WriteLine("Rest Time Starts");

                    Thread.Sleep(5000);
                    Console.Clear();
                }
                WorkPomodoro();
                void RestPomodoro()
                {
                    DateTime RestStartTime = DateTime.Now;
                    for (int i = 0; i <= test._restDuration * 60; i++)
                    {
                        Console.Write("Rest Time Remains : {0}", restTime.ToString("mm:ss"));
                        restTime = restTime.AddSeconds(-1);
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    Console.WriteLine("Rest Time Over, Press Y to start over or any other key to terminate");
                    var Option = Console.ReadLine().ToUpper();
                    /* Option == "Y" ? RestartPomodoro() : return ; */
                    if (Option == "Y")
                    {
                        RestartPomodoro();
                    }
                    else
                    {
                        return;
                    }
                    DateTime RestStopTime = DateTime.Now;
                }

                RestPomodoro();
            }
            else
            {
                Console.WriteLine("Wrong Input Format!!!");
                RestartPomodoro();
            }


            void RestartPomodoro()
            {
                PomodoroRule();
            }
        }
    }
}
