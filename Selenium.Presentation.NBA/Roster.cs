using Selenium.Presentation.NBA.Interfaces;

namespace Selenium.Presentation.NBA
{
    public class Roster
    {
        private IPlayerStatisticsProcessor _psProcessor;
        private IRosterRollerProcessor _rrProcessor;

        public Roster(IPlayerStatisticsProcessor psProcessor, IRosterRollerProcessor rrProcessor)
        {
            _psProcessor = psProcessor;
            _rrProcessor = rrProcessor;
        }

        public void Execute()
        {

        }
    }
}
