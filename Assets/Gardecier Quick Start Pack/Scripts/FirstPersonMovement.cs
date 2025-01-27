using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonMovement : MonoBehaviour
{
    public InputSystem inputs;
    public float speed;

    public Transform cursor;
    public Transform mesh;

    void Start()
    {
        inputs.OnMovement += Movement;
    }

    public void Movement(InputAction.CallbackContext context)
    {
        Vector2 inputVector = context.ReadValue<Vector2>();
        transform.Translate(new Vector3(inputVector.x, 0f, inputVector.y) * speed * Time.deltaTime);
    }

    void Update()
    {
        mesh.rotation = Quaternion.LookRotation(Vector3.RotateTowards(mesh.forward, cursor.position, 1, 0.0f));
        Vector3 eulerAngles = mesh.rotation.eulerAngles;
	    eulerAngles.x = 0;
	    eulerAngles.z = 0;

	    mesh.rotation = Quaternion.Euler(eulerAngles);
    }
}
