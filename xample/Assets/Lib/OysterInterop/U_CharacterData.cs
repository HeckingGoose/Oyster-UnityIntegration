using Assets.Lib.OysterInterop.Inherit;
using Oyster.Core.AbstractTypes.Character;
using UnityEngine;

namespace Assets.Lib.OysterInterop
{
    public class U_CharacterData : MonoBehaviour
    {
        // Editor Variables
        [SerializeField]
        protected string _name;
        [SerializeField]
        protected Color _nameColour;
        [SerializeField]
        protected float _timeBetweenCharacters;
        [SerializeField]
        protected string _scriptName;
        [SerializeField]
        protected string _scriptPath;

        // Protected Variables
        protected CharacterData _characterData;

        // On start
        protected virtual void Start()
        {
            if (_characterData == null) MakeData();
        }

        // Private Methods
        private void MakeData()
        {
            // Make character data
            _characterData = new CharacterData(
                _name,
                _nameColour.ToOysterColour(),
                _timeBetweenCharacters,
                _scriptName,
                _scriptPath
                );
        }

        // Accessors
        public A_CharacterData Data
        {
            get
            {
                if (_characterData == null) MakeData();
                return _characterData;
            }
        }
    }
}
