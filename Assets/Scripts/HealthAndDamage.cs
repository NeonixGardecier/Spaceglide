using UnityEngine;

public class HealthAndDamage : MonoBehaviour
{
    public Stats stats;

    public float health;

    void Update()
    {
        if (health > stats.maxHealth){health = stats.maxHealth;}
    }

    public void Damage(GameObject source, float damage, string damageType)
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

            break;
        }
    }
}
