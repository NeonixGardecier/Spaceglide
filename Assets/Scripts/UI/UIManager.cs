using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Stats playerStats;
    public ItemData itemData;

    public Texture[] itemTextureLibrary;


    void Update()
    {
        UpdateItems();
    }


    public RawImage[] itemSlotImages;
    void UpdateItems()
    {
        itemSlotImages[0].texture = itemTextureLibrary[itemData.GetItemData(playerStats.Inventory_Slot1).spriteID];
        itemSlotImages[1].texture = itemTextureLibrary[itemData.GetItemData(playerStats.Inventory_Slot2).spriteID];
        itemSlotImages[2].texture = itemTextureLibrary[itemData.GetItemData(playerStats.Inventory_Slot3).spriteID];
        itemSlotImages[3].texture = itemTextureLibrary[itemData.GetItemData(playerStats.Inventory_Slot4).spriteID];
        itemSlotImages[4].texture = itemTextureLibrary[itemData.GetItemData(playerStats.Inventory_Slot5).spriteID];
        itemSlotImages[5].texture = itemTextureLibrary[itemData.GetItemData(playerStats.Inventory_Slot6).spriteID];
    }

    public GameObject tooltipOb;
    public RawImage itemImage;
    public TextMeshProUGUI itemName;
    public TextMeshProUGUI itemLore;
    public TextMeshProUGUI itemValue;
    public TextMeshProUGUI itemStats;
    public TextMeshProUGUI itemPassiveName;
    public TextMeshProUGUI itemPassiveText;

    public void OpenToolTip(int slot)
    {
        idata thisSlot = new idata();

        switch (slot)
        {
            default: return; break;

            case 1: thisSlot = playerStats.slot1Data; break;
            case 2: thisSlot = playerStats.slot2Data; break;
            case 3: thisSlot = playerStats.slot3Data; break;
            case 4: thisSlot = playerStats.slot4Data; break;
            case 5: thisSlot = playerStats.slot5Data; break;
            case 6: thisSlot = playerStats.slot6Data; break;
        }

        itemImage.texture = itemTextureLibrary[thisSlot.spriteID];
        itemName.text = thisSlot.itemName;
        itemLore.text = thisSlot.loreText;
        itemValue.text = "" + thisSlot.Value;
        //ITEM PASSIVE NAME
        //ITEM PASSIVE TEXT
        
        itemStats.text = "" + ProcessStatText(thisSlot);

        if (thisSlot.itemName != "")
        {
            tooltipOb.SetActive(true);            
        }
    }

    public void CloseToolTip()
    {
        tooltipOb.SetActive(false);
    }

    public string ProcessStatText(idata input)
    {
        string output = "";

        if (input.maxHealth != 0){output = output + GetSymbol(input.maxHealth) + input.maxHealth + " Max Health \n";}
        if (input.healthRegen != 0){output = output + GetSymbol(input.healthRegen) + input.healthRegen + " Regeneration \n";}
        if (input.elementalPower != 0){output = output + GetSymbol(input.elementalPower) + input.elementalPower + " Elemental Power \n";}
        if (input.strikePower != 0){output = output + GetSymbol(input.strikePower) + input.strikePower + " Strike Power \n";}
        if (input.fortitude != 0){output = output + GetSymbol(input.fortitude) + input.fortitude + " Elemental Resistance \n";}
        if (input.defence != 0){output = output + GetSymbol(input.defence) + input.defence + " Strike Resistance \n";}
        if (input.fleetness != 0){output = output + GetSymbol(input.fleetness) + input.fleetness + " Move Speed \n";}
        if (input.attackSpeed != 0){output = output + GetSymbol(input.attackSpeed) + input.attackSpeed + " Max Health \n";}
        if (input.projectileSpeed != 0){output = output + GetSymbol(input.projectileSpeed) + input.projectileSpeed + " Max Health \n";}

        return output;
    }

    public string GetSymbol(float input)
    {
        string output = "";

        if (input > 0)
        {
            output = "+";
        }            
    
        return output;
    }
}
