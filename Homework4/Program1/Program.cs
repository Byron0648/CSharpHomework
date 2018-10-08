using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        public class AlarmEventArgs:EventArgs
        {
            public bool ifOnTime;//是否到时间
        }

        public delegate void AlarmEventHander(object sender, AlarmEventArgs e);

        public class AlarmClock
        {
            public DateTime alarmTime;//闹钟时间
            
            
                
            public event AlarmEventHander Alarming;//事件

            public void RunTime()
            {

                DateTime time = DateTime.Now;
                while (time<alarmTime)
                {
                    time = DateTime.Now;
                    if (time > alarmTime) time = alarmTime;
                    if (Alarming != null)
                    {
                        AlarmEventArgs args = new AlarmEventArgs();
                        args.ifOnTime = (time == alarmTime);
                        Alarming(this, args);

                    }
                }
                
            }
        }

        static void Main(string[] args)
        {
            
            string s = "";
            Console.WriteLine("输入闹钟格式为 yyyy-MM-dd hh:mm:ss");
            s = Console.ReadLine();

            var alarm = new AlarmClock();
            try
            {
                alarm.alarmTime = DateTime.Parse(s);
            }
            catch
            {
                Console.WriteLine("您输入的闹钟格式不正确！");
            }
            
            alarm.Alarming += ShowTime;
            alarm.RunTime();
            Console.WriteLine("按任意键继续");
            Console.ReadKey();

        }

        static void ShowTime(object sender,AlarmEventArgs e)
        {
            if (e.ifOnTime == true) Console.WriteLine("闹钟时间到了");
            
        }
    }
}
