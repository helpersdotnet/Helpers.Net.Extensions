using System;
using System.Drawing;

namespace Helpers.Net.Extensions
{
    public static partial class Extensions
    {
        /// <summary>
        /// Converts a color object into a hex color value
        /// that can be used as an HTML color
        /// </summary>
        /// <param name="color">System.Drawing.Color</param>
        /// <returns>a hex value</returns>
        public static string ToHexString(this Color color)
        {
            string hexR;
            string hexB;
            string hexG;

            try
            {
                //Get Red Hex
                hexR = Convert.ToString(color.R, 16).ToUpper();
                if (hexR.Length < 2)
                    hexR = "0" + hexR;

                //Get Green Hex
                hexG = Convert.ToString(color.G, 16).ToUpper();
                if (hexG.Length < 2)
                    hexG = "0" + hexG;

                //Get Blue Hex
                hexB = Convert.ToString(color.B, 16).ToUpper();
                if (hexB.Length < 2)
                    hexB = "0" + hexB;

            }
            catch
            {
                return "";
            }

            return "#" + hexR + hexG + hexB;
        }
    }
}
