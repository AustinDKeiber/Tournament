using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the tournament name.
        /// </summary>
        public String TournamentName { get; set; }
        
        /// <summary>
        /// Represents the cost of entry for this tournament.
        /// </summary>
        public Decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the teams that are participating within 
        /// the tournament.
        /// </summary>
        public List<TeamModel> Teams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the prizes that are available to the tournament 
        /// winners.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the matchups that will occur within each round.
        /// </summary>
        public List<List<MatchupModel>> Round { get; set; } = new List<List<MatchupModel>>();
    }
}
