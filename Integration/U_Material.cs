using Assets.Lib.OysterInterop.Inherit;
using UnityEngine;

namespace Assets.Lib.OysterInterop
{
    internal class U_Material : MonoBehaviour
    {
        // Editor Variables
        [SerializeField]
        private string _name;
        [SerializeField]
        private Material _material;

        // Private Variables
        private Material_Internal _materialInternal;

        // On Start
        private void Start()
        {
            // Make material
            if (_materialInternal == null) MakeMaterial();
        }

        // Private Methods
        private void MakeMaterial()
        {
            _materialInternal = new Material_Internal(_name, _material);
        }

        // Accessors
        public Material_Internal Material
        {
            get
            {
                if (_materialInternal == null) MakeMaterial();
                return _materialInternal;
            }
        }
    }
}
