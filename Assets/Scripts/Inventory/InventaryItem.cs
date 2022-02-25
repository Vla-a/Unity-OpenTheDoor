using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventaryItem : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private InventoryImage inventoryImage;
    public InventaryType type;

    public void setItemType(InventaryType type)
    {
        this.type = type;
        image.sprite = inventoryImage.GetItemByType(type);
    }
}
