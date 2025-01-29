using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class Attack : MonoBehaviour
{
    public Stats stats;
    public InputSystem inputSystem;

    public GameObject projectile;
    public Transform projSpawn;
    public string damageType;

    void Start()
    {
        inputSystem.OnRightClickInput += OnClick;
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        DoAttack();
    }

    bool canFire = true;
    public void DoAttack()
    {
        if (!canFire) return;

        StartCoroutine(FireDelay());

        Projectile instProj = Instantiate(projectile, projSpawn.position, projSpawn.rotation).GetComponent<Projectile>();

        //Set the projectile Data
        instProj.movementSpeed = stats.projectileSpeed;
        instProj.team = (int)stats.team;
        instProj.damageType = damageType;
        instProj.source = this.gameObject;

        if (damageType == "Strike")
        {
            instProj.damageAmount = stats.strikePower;
        }
        else
        {
            instProj.damageAmount = stats.elementalPower;
        }

        if (stats.isPlayer)
        {
            instProj.gameObject.layer = LayerMask.NameToLayer("PlayerProj");
        }
        else{
            instProj.gameObject.layer = LayerMask.NameToLayer("EnemyProj");
        }

    }

    IEnumerator FireDelay()
    {
        canFire = false;
        yield return new WaitForSeconds(1 / (stats.attackSpeed + stats.bonus_attackSpeed));
        canFire = true;
    }
}
