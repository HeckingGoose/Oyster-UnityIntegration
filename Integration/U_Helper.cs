using Oyster.Core.Types;
using UnityEngine;

namespace Assets.Lib.OysterInterop
{
    internal static class U_Helper
    {
        // Helper Functions
        /// <summary>
        /// Converts a given Oyster colour into a Unity colour.
        /// </summary>
        public static Color ToUnityColour(this Colour colour)
        {
            // Make new unity colour and return
            return new Color
                (
                    colour.ByteRed / 255f,
                    colour.ByteGreen / 255f,
                    colour.ByteBlue / 255f,
                    colour.ByteAlpha / 255f
                );
        }
        /// <summary>
        /// Converts a given Unity colour into an Oyster colour.
        /// </summary>
        public static Colour ToOysterColour(this Color colour)
        {
            // Make new Oyster colour and return
            return new Colour(
                    (byte)(colour.r * 255),
                    (byte)(colour.g * 255),
                    (byte)(colour.b * 255),
                    (byte)(colour.a * 255)
                );
        }
    }
}
