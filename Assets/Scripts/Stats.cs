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


     float item_maxHealth; //Displayed as "Health" on stat screens
     float item_healthRegen; //Displayed as "Vitality"
     float item_elementalPower; //Sometimes shown as EP
     float item_strikePower; //acts as physical damage for auto attacks and some passives
     float item_fortitude; //Lowers elemental damage taken
     float item_defence; //Lowers strike damage taken
     float item_fleetness; //Movement speed
     float item_attackSpeed;
     float item_projectileSpeed;

    void UpdateInventoryStats()
    {
        idata slot1Data = itemData.GetItemData(Inventory_Slot1);
        idata slot2Data = itemData.GetItemData(Inventory_Slot2);
        idata slot3Data = itemData.GetItemData(Inventory_Slot3);
        idata slot4Data = itemData.GetItemData(Inventory_Slot4);
        idata slot5Data = itemData.GetItemData(Inventory_Slot5);
        idata slot6Data = itemData.GetItemData(Inventory_Slot6);

        item_maxHealth       = slot1Data.maxHealth       + slot2Data.maxHealth       + slot3Data.maxHealth       + slot4Data.maxHealth       + slot5Data.maxHealth       + slot6Data.maxHealth;
        item_healthRegen     = slot1Data.healthRegen     + slot2Data.healthRegen     + slot3Data.healthRegen     + slot4Data.healthRegen     + slot5Data.healthRegen     + slot6Data.healthRegen;
        item_elementalPower  = slot1Data.elementalPower  + slot2Data.elementalPower  + slot3Data.elementalPower  + slot4Data.elementalPower  + slot5Data.elementalPower  + slot6Data.elementalPower;
        item_strikePower     = slot1Data.strikePower     + slot2Data.strikePower     + slot3Data.strikePower     + slot4Data.strikePower     + slot5Data.strikePower     + slot6Data.strikePower;
        item_fortitude       = slot1Data.fortitude       + slot2Data.fortitude       + slot3Data.fortitude       + slot4Data.fortitude       + slot5Data.fortitude       + slot6Data.fortitude;
        item_defence         = slot1Data.defence         + slot2Data.defence         + slot3Data.defence         + slot4Data.defence         + slot5Data.defence         + slot6Data.defence;
        item_fleetness       = slot1Data.fleetness       + slot2Data.fleetness       + slot3Data.fleetness       + slot4Data.fleetness       + slot5Data.fleetness       + slot6Data.fleetness;
        item_attackSpeed     = slot1Data.attackSpeed     + slot2Data.attackSpeed     + slot3Data.attackSpeed     + slot4Data.attackSpeed     + slot5Data.attackSpeed     + slot6Data.attackSpeed;
        item_projectileSpeed = slot1Data.projectileSpeed + slot2Data.projectileSpeed + slot3Data.projectileSpeed + slot4Data.projectileSpeed + slot5Data.projectileSpeed + slot6Data.projectileSpeed;

    }
}
