using Selenium.Presentation.AC.Abstracts;
using System.Threading;

namespace Selenium.Presentation.AC.Controls.Waiters
{
    public class SimpleWait : BaseWait
    {
        private int _millisecends;

        public SimpleWait(int millisecends = 2000)
        {
            _millisecends = millisecends;
        }

        protected override void Wait()
        {
            Thread.Sleep(_millisecends);
        }
    }
}
