using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonMovement : MonoBehaviour
{
    public InputSystem inputs;
    public float speed;
    public float moveNeg;

    public Transform cursor;
    public Transform mesh;

    void Start()
    {
        inputs.OnMovement += Movement;
    }

    public void Movement(InputAction.CallbackContext context)
    {
        Vector2 inputVector = context.ReadValue<Vector2>();
        transform.Translate(new Vector3(inputVector.x, 0f, inputVector.y) * (speed / moveNeg) * Time.deltaTime);
    }

    void Update()
    {
        // Get the direction to the cursor
        Vector3 directionToCursor = cursor.position - mesh.position; 
        directionToCursor.y = 0; // Keep the rotation on the horizontal plane

        // Only calculate the rotation if the direction vector is not zero
        if (directionToCursor != Vector3.zero)
        {
            // Create a rotation that looks in that direction
            Quaternion targetRotation = Quaternion.LookRotation(directionToCursor);

            // Smoothly rotate towards the target direction
            mesh.rotation = Quaternion.Slerp(mesh.rotation, targetRotation, 20);
        }

        if (inputs.rightClickHeld)
        {
            moveNeg = 5;
        }
        else{
            moveNeg = 1;
        }
    }
}
