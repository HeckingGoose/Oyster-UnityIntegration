using Oyster.Core;
using UnityEngine;
using UnityEngine.InputSystem;

public class Nudger : MonoBehaviour
{
    // Private Variables
    private InputAction _nudge;

    // Unity Methods
    private void Start()
    {
        // Sub
        _nudge = InputSystem.actions.FindActionMap("Player").FindAction("Attack");
        _nudge.performed += OnAction;
    }
    private void OnDestroy()
    {
        _nudge.performed -= OnAction;
    }

    // Private Methods
    private void OnAction(InputAction.CallbackContext obj)
    {
        OysterMain.Nudge();
    }
}
