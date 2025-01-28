using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float movementSpeed;

    public int team;
    public string damageType;
    public float damageAmount;
    public GameObject source;

    void FixedUpdate() 
    {
        transform.position += transform.forward * Time.deltaTime * movementSpeed;
    }
}
