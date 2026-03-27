using Oyster;
using UnityEngine;

namespace Assets.Lib.OysterInterop
{
    public static class OysterLogger
    {
        // Constructor
        static OysterLogger()
        {
            // Listen to Oyster debug messages
            DebugOut.OnDebugMessage += DebugMessage;
        }

        // Public Methods
        public static void DebugMessage(string message, DebugOut.Severity severity)
        {
            // Based on severity, log it
            switch (severity)
            {
                case DebugOut.Severity.Log:
                    Debug.Log(message);
                    break;
                case DebugOut.Severity.Warn:
                    Debug.LogWarning(message);
                    break;
                default:
                case DebugOut.Severity.Error:
                    Debug.LogError(message);
                    break;
            }
        }
    }
}
