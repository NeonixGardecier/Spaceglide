using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemTooltipHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public UIManager uiManager;
    public int slot;

    public void OnPointerEnter(PointerEventData eventData)
    {
        uiManager.OpenToolTip(slot);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        uiManager.CloseToolTip();
    }
}
