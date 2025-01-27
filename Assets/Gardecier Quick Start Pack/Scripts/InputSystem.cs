using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystem : MonoBehaviour
{
    public delegate void OnInputChanged(InputAction.CallbackContext context);

    public event OnInputChanged OnMovement;

    bool movingHeld;
    InputAction.CallbackContext movementContext;

    public event OnInputChanged OnRightClickInput;

    void Update()
    {
        if (movingHeld)
        {
            OnMovement.Invoke(movementContext);
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if(context.performed)
        { 
            movingHeld = true;
            movementContext = context;
        }
        if(context.canceled)
        {
            movingHeld = false;
        }
    }

    public void OnRightClick(InputAction.CallbackContext context)
    {
        OnRightClickInput.Invoke(context);
    }
}
