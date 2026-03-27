using Assets.Lib.OysterInterop.Inherit;
using Oyster.Core;
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
        private GameObject _playerLooker;

        // On Start
        private void Start()
        {
            if (_oysterCamera == null) MakeCamera();

            // Sub
            OysterMain.OnScriptReady += StopTracking;
            OysterMain.OnSpeechCompleted += ResumeTracking;
        }
        private void OnDestroy()
        {
            // UnSub
            OysterMain.OnScriptReady -= StopTracking;
            OysterMain.OnSpeechCompleted -= ResumeTracking;
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

        // Private Methods
        private void MakeCamera()
        {
            // Generate a new gameobject facing just in front of the camera
            _playerLooker = new GameObject();
            _playerLooker.transform.position = _camera.transform.position + _camera.transform.forward;
            _playerLooker.name = "PlayerLookTarget";

            // Parent it
            _playerLooker.transform.parent = _camera.transform;

            // Now make a looker
            U_LookTarget looker = (U_LookTarget)_playerLooker.AddComponent(typeof(U_LookTarget));
            looker.Name = "PlayerLookTarget";

            // Make camera
            _oysterCamera = new Camera_Internal(ref _camera, looker.Looker);
        }
        private void ResumeTracking()
        {
            _camera.transform.forward = Vector3.Normalize(_playerLooker.transform.position - _camera.transform.position);
            _playerLooker.transform.parent = _camera.transform;
        }
        private void StopTracking()
        {
            _playerLooker.transform.parent = null;
        }

        // Accessors
        /// <summary>
        /// Gets a reference to this camera's internal Oyster camera.
        /// </summary>
        public Camera_Internal OysterCamera
        {
            get
            {
                if (_oysterCamera == null) MakeCamera();
                return _oysterCamera;
            }
        }
    }
}