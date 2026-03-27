using Assets.Lib.OysterInterop.Inherit;
using UnityEngine;

namespace Assets.Lib.OysterInterop
{
    public class U_Camera : MonoBehaviour
    {
        // Const
        private float LOOK_SPEED = 2f;

        // Editor Variables
        [SerializeField]
        private Camera _camera;

        // Private Variables
        private Camera_Internal _oysterCamera;

        // On Start
        void Awake()
        {
            // Generate a new gameobject facing just in front of the camera
            GameObject nob = new GameObject();
            nob.transform.position = _camera.transform.position + _camera.transform.forward;
            nob.name = "PlayerLookTarget";

            // Parent it
            nob.transform.parent = _camera.transform;

            // Now make a looker
            U_LookTarget looker = (U_LookTarget)nob.AddComponent(typeof(U_LookTarget));
            looker.Name = "PlayerLookTarget";

            // Make camera
            _oysterCamera = new Camera_Internal(ref _camera, looker.Looker);
        }
        private void FixedUpdate()
        {
            // Move camera towards target
            _camera.transform.forward = Vector3.Lerp(
                _camera.transform.forward,
                Vector3.Normalize(((GameObject)_oysterCamera.LookTarget.Target).transform.position - _camera.transform.position),
                Time.fixedDeltaTime * LOOK_SPEED
                );
        }

        // Accessors
        /// <summary>
        /// Gets a reference to this camera's internal Oyster camera.
        /// </summary>
        public Camera_Internal OysterCamera
        {
            get { return _oysterCamera; }
        }
    }
}