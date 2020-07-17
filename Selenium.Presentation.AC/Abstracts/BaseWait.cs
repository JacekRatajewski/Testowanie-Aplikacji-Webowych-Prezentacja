using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium.Presentation.AC.Abstracts
{
    public abstract class BaseWait
    {
        public void Action()
        {
            Wait();
        }

        protected abstract void Wait();
    }
}
