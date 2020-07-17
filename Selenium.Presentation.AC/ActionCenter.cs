using Selenium.Presentation.AC.Abstracts;

namespace Selenium.Presentation.AC
{
    public class ActionCenter
    {
        public void Wait(BaseWait wait)
        {
            wait.Action();
        }
    }
}
