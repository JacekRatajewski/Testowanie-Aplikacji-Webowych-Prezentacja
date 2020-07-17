using Selenium.Presentation.NBA.Interfaces;
using Selenium.Presentation.NBA.Models;
using System.Collections.Generic;

namespace Selenium.Presentation.NBA.Processors
{
    public class RosterRollerProcessor : IRosterRollerProcessor
    {
        private List<string> _teams;

        public Dictionary<string, Player[]> GetRosterForPlayers(Player[] players)
        {
            return null;
        }

        private void InitTeams()
        {
            _teams = new List<string>
            {
                "Houston Rocets",
                "Golden State Warriors",
                "Milawukee Bucks",
                "Toronto Raptors",
                "Chicago Bulls",
                "Los Angeles Lakers"
            };
        }

        private void Roll()
        {

        }
    }
}
