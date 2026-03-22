using System;

namespace Skat
{
    public class Afgift
    {
        /// <summary>
        /// Udregner registreringsafgiften på en personbil
        /// udfra prisen
        /// </summary>
        /// <param name="pris">prisen på bilen</param>
        /// <returns>afgiften på bilen</returns>
        public int BilAfgift(int pris)
        {
            double bilAfgift = 0;
            if (pris < 0)
            {
                throw new ArgumentException("pris kan ikke være under 0");
            }

            if (pris <= 200000)
            {
                bilAfgift = pris * 0.85;
            }

            else
            {
                bilAfgift = (pris * 1.50) - 130000;
            }

            return (int)bilAfgift;
        }

        /// <summary>
        /// Udregner registreringsafgiften på en elbil
        /// udfra prisen
        /// </summary>
        /// <param name="pris">prisen på elbilen</param>
        /// <returns>afgiften på elbilen</returns>
        public int ElBilAfgift(int pris)
        {
            double elBilAfgift = BilAfgift(pris) * 0.20;
            return (int)elBilAfgift;
        }
    }
}
