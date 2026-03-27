using Oyster.Core.AbstractTypes;
using Oyster.Core.AbstractTypes.Character;
using Oyster.Core.Types;

namespace Assets.Lib.OysterInterop.Inherit
{
    public class CharacterData : A_CharacterData
    {
        // Private Variables
        private string _scriptName;
        private string _lastScriptName;
        private string _scriptPreface;

        // Constructor
        public CharacterData(
            string name,
            Colour nameColour,
            float timeBetweenCharacters,
            string scriptName,
            string scriptPreface
            ) : base(name, nameColour, timeBetweenCharacters)
        {
            // Pass Values
            _scriptPreface = scriptPreface;
            _scriptName = scriptName;
            SetScript(scriptName);
            _lastScriptName = _scriptName;
        }

        // Public Methods
        public override A_BackgroundAssetLoader<string> BeginScriptLoad()
        {
            // Make asset loader and return
            return new U_ScriptLoader(_scriptName);
        }
        public override void RevertScript()
        {
            _scriptName = _lastScriptName;
        }

        public override void SetScript(string scriptName)
        {
            // Set value
            _lastScriptName = _scriptName;
            _scriptName = $"{_scriptPreface}{scriptName}.osf";

            // Do base method
            base.SetScript(scriptName);
        }
    }
}
