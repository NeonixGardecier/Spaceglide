using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float movementSpeed;

    public int team;
    public string damageType;
    public float damageAmount;
    public GameObject source;

    public bool homing;
    public Transform homingTarget;

    public bool destroyOnHit;

    public float lifetime;

    void FixedUpdate() 
    {
        transform.position += transform.forward * Time.deltaTime * movementSpeed;
    }

    void Start()
    {
        Destroy(this.gameObject, lifetime);
    }
}
