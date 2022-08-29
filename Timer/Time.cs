using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    internal class Time
    {
        public int minutes { get; set; }
        public int seconds { get; set; }
        public int miliseconds { get; set; }
        public int breakTime { get; set; }

        public string breakString(int time)
        {
            string sec = "";
            if (time < 10) sec = "0" + time.ToString();
            else sec = time.ToString();
            string text = "00:" + sec + ":00";
                return text;
        }
        public override string ToString()
        {
            string text = "";
            if (minutes < 10) text += "0" + minutes + ":";
                else text += minutes.ToString()+":";
            if(seconds<10)text += "0" + seconds + ":";
                else text += seconds.ToString() + ":";
            if (miliseconds < 10) text += "0" + miliseconds;
                else text += miliseconds.ToString();

            return text;
        }
    }
}
