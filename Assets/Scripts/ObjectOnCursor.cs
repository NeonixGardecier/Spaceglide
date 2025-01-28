using UnityEngine;

public class ObjectOnCursor : MonoBehaviour
{   
    public Vector3 cursorPosition;
    public Transform cursorObject;
    Camera cam;

    void Start()
    {
        cam = this.gameObject.GetComponent<Camera>();
    }

    public void Update()
    {
        cursorPosition = Input.mousePosition; //Get mouse position

        cursorPosition = Camera.main.ScreenToWorldPoint(transform.position + new Vector3(cursorPosition.x, cursorPosition.y, 13f)); //Set the Z to 1 so it hovers just off the ground

        cursorObject.position = cursorPosition;   //set the cursor object's position
    }
}

