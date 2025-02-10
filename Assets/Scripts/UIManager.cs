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
}
