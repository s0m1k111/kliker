using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kliker
{
    internal class Delay
    {
        private int count = 0;
        private int time = 0;
        private Action action;
        private System.Windows.Forms.Timer timer;
        public void Start(System.Windows.Forms.Timer timer, int time, Action action)
        {
            timer.Start();
            this.time = time;
            this.action = action;
            this.timer = timer;
        }
        public void Tick()
        {
            count++;
            if (count > time)
            {
                action();
                timer.Stop();
                count = 0;
            }
        }
    }
}
