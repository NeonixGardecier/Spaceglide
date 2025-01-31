using UnityEngine;

public enum items //Pool of items
{
    None, Sword
}

public class Stats : MonoBehaviour
{
    public float team;
    public bool isPlayer;

    [Header("Stats")]
    public float maxHealth; //Displayed as "Health" on stat screens
    public float healthRegen; //Displayed as "Vitality"

    public float elementalPower; //Sometimes shown as EP
    public float strikePower; //acts as physical damage for auto attacks and some passives

    public float fortitude; //Lowers elemental damage taken
    public float defence; //Lowers strike damage taken

    public float fleetness; //Movement speed

    public float attackSpeed; //Attacks per second
    public float projectileSpeed;


    //Stats gains from item PASSIVES and external sources
    [Header("Bonus Stats")] 
    public float bonus_maxHealth; //Displayed as "Health" on stat screens
    public float bonus_healthRegen; //Displayed as "Vitality"

    public float bonus_elementalPower; //Sometimes shown as EP
    public float bonus_strikePower; //acts as physical damage for auto attacks and some passives

    public float bonus_fortitude; //Lowers elemental damage taken
    public float bonus_defence; //Lowers strike damage taken

    public float bonus_fleetness; //Movement speed

    public float bonus_attackSpeed;
    public float bonus_projectileSpeed;

    [Header("Inventory")]
    public ItemData itemData;
    public items Inventory_Slot1;
    public items Inventory_Slot2;
    public items Inventory_Slot3;
    public items Inventory_Slot4;
    public items Inventory_Slot5;
    public items Inventory_Slot6;

    void Update()
    {
        UpdateInventoryStats();
    }

    void UpdateInventoryStats()
    {
        
    }
}
