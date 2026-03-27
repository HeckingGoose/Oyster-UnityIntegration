using Oyster.Core.AbstractTypes.Player;

namespace Assets.Lib.OysterInterop.Inherit
{
    public class PlayerTalker : A_PlayerTalker
    {
        // Constructor
        public PlayerTalker(A_Camera camera, A_SpeechDisplay speechDisplay) : base(camera, speechDisplay) { }
    }
}