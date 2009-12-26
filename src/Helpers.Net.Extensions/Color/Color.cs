using System;
using System.Drawing;

namespace Helpers.Net.Extensions
{
    public static class Extensions
    {
        /// <summary>
        /// Converts a color object into a hex color value
        /// that can be used as an HTML color
        /// </summary>
        /// <param name="color">System.Drawing.Color</param>
        /// <returns>a hex value</returns>
        public static string ToHexString(this Color color)
        {
            string HexR = null;
            string HexB = null;
            string HexG = null;

            try
            {
                //Get Red Hex
                HexR = Convert.ToString(color.R, 16).ToUpper();
                if (HexR.Length < 2)
                    HexR = "0" + HexR;

                //Get Green Hex
                HexG = Convert.ToString(color.G, 16).ToUpper();
                if (HexG.Length < 2)
                    HexG = "0" + HexG;

                //Get Blue Hex
                HexB = Convert.ToString(color.B, 16).ToUpper();
                if (HexB.Length < 2)
                    HexB = "0" + HexB;

            }
            catch
            {
                return "";
            }

            return "#" + HexR + HexG + HexB;
        }
    }
}
