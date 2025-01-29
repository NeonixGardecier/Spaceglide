using UnityEngine;

public class HealthAndDamage : MonoBehaviour
{
    public Stats stats;

    public float health;

    void Update()
    {
        if (health > stats.maxHealth){health = stats.maxHealth;}
    }

    public void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "proj")
        {
            Projectile hitProj = other.gameObject.GetComponent<Projectile>();

            Damage(hitProj.source, hitProj.damageAmount, hitProj.damageType, hitProj.team);

            if (hitProj.destroyOnHit)
            {
                Destroy(other.gameObject);
            }
        }
    }

    float damageToTake;
    public void Damage(GameObject source, float damage, string damageType, int team)
    {
        switch(damageType)
        {
            default: //Arcana - no special effect

            break;

            case "fire": //Deals an additional 15% damage over 5 seconds

            break;

            case "ice": //Slows by 10% on hit (stacks)

            break;

            case "wind": //Pushes away from the damage source (scales with damage done)

            break;

            case "Poison":  //Deals damage over 5 seconds

            break;

            case "Strike":
                damageToTake = damage - (stats.defence + stats.bonus_defence);
            break;
        }

        if (damageToTake < 0){damageToTake = 0;}

        health -= damageToTake;

        source.GetComponent<HealthAndDamage>().ReturnedDamageHit(source, damage, damageType, team);
    }

    public void ReturnedDamageHit(GameObject source, float damage, string damageType, int team)
    {

    }
}
