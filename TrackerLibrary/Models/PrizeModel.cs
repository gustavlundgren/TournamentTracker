using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique id for the prize
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the place the team got
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of that place
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the prize in dollars
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the prize as a percentage 
        /// of the tournaments income
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string plceNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(plceNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal priceAmountValue = 0;
            decimal.TryParse(prizeAmount, out priceAmountValue);
            PrizeAmount = priceAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
