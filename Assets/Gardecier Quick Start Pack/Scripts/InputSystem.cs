using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystem : MonoBehaviour
{
    public delegate void OnInputChanged(InputAction.CallbackContext context);

    public event OnInputChanged OnMovement;
    bool movingHeld;
    InputAction.CallbackContext movementContext;

    public event OnInputChanged OnRightClickInput;
    bool rightClickHeld;
    InputAction.CallbackContext rightClickContext;

    void Update()
    {
        if (movingHeld)
        {
            OnMovement.Invoke(movementContext);
        }

        if (rightClickHeld)
        {
            OnRightClickInput.Invoke(rightClickContext);
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
        if(context.performed)
        { 
            rightClickHeld = true;
            rightClickContext = context;
        }
        if(context.canceled)
        {
            rightClickHeld = false;
        }
    }
}
