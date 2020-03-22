using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Problem1
    {
        private int maxCount;
        private int current;

        public Problem1(int passedThreshold)
        {
            maxCount = passedThreshold;
        }

        public void Plus(int x)
        {
            current += x;
            if (current >= maxCount)
            {
                EventOnMaxCount(EventArgs.Empty);
            }
        }
        public void Show()
        {
            Console.WriteLine(current);
        }

        protected virtual void EventOnMaxCount(EventArgs e)
        {
            EventHandler handler = MaxCountReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler MaxCountReached;
    }
}
