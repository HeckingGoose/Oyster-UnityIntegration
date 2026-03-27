using Oyster.Core.AbstractTypes.Scene;
using UnityEngine;

namespace Assets.Lib.OysterInterop
{
    public class U_LookTarget : MonoBehaviour
    {
        // Editor Variables
        [SerializeField]
        private string _name;
        [SerializeField]
        private GameObject _target;

        // Private Variables
        private A_Looker _looker;

        // On start
        private void Awake()
        {
            // Set to self if null
            if (_target == null) _target = gameObject;

            // If empty set to object name
            if (_name == string.Empty) _name = gameObject.name;

            // Make looker
            _looker = new A_Looker(_name, _target);
        }

        // Accessors
        public string Name { get { return _name; } set { _name = value; } }
        public GameObject Target { get { return _target; } }
        public A_Looker Looker { get { return _looker; } }
    }
}
