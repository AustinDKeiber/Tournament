using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {

        /// <summary>
        /// Represents the position that is associated with this prize.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of the Prize.
        /// </summary>
        public String PlaceName { get; set; }

        /// <summary>
        /// Represents the amount, in dollars, that the winner
        /// will recieve.
        /// </summary>
        public decimal PriceAmount { get; set; }

        /// <summary>
        /// Represents the percentage of the total wagered money
        /// in the tournament that this winner will recieve.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
