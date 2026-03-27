using Oyster.Core.AbstractTypes.Player;
using Oyster.Core.AbstractTypes.Scene;
using UnityEngine;

namespace Assets.Lib.OysterInterop.Inherit
{
    public class Camera_Internal : A_Camera
    {
        // Private Variables
        private Camera _camera;

        // Constructor
        public Camera_Internal(
            ref Camera camera,
            A_Looker playerTarget
            ) : base(playerTarget)
        {
            // Pass Value
            _camera = camera;
        }

        // Accessors
        public override int FOV
        {
            get
            {
                return (int)_camera.fieldOfView;
            }
            set
            {
                _camera.fieldOfView = value;
            }
        }
    }
}
