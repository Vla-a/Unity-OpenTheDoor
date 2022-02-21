using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddInventaru : MonoBehaviour
{
    [SerializeField] private InventaryItem prefubItem;
    [SerializeField] private InventoryImage inventoryImage;
    [SerializeField] private GameObject parentForInventorySlot;

    private void Start()
    {
        GameController.Instance.Inventary += AddItem;
    }

    private void OnDestroy()
    {
        GameController.Instance.Inventary -= AddItem;
    }

    public void AddItem(InventaryType inventaryType)    {

        InventaryItem inventorySlot = Instantiate(prefubItem, parentForInventorySlot.transform);        
        inventorySlot.setItemType(inventaryType);   

    }
}
