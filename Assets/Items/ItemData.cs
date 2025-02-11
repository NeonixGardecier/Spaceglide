using UnityEngine;

public class idata
{
    public string itemName;
    public string loreText;

    public int spriteID;

    public int Value;

    public int passiveID1;

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
}

public class ItemData : MonoBehaviour
{
    public Stats stats;



                //ITEM DATAS
    //-------------------------------------------------------------------------
    public idata GetItemData(items item)
    {
        idata returnData = new idata();

        switch (item)
        {
            case items.None:
                returnData.itemName = "";
                returnData.spriteID = 0;
            break;
            case items.Sword:
                returnData.itemName = "Sword";
                returnData.strikePower = 10;
                returnData.Value = 75;

                returnData.spriteID = 1;
            break;
        }
        return returnData;
    }

                //ITEM DATAS
    //-------------------------------------------------------------------------
    public void UsePassive(int id, GameObject source, GameObject Target)
    {

    }
}
