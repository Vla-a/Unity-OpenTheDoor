using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddInventaru : MonoBehaviour
{
    [SerializeField] private InventaryItem prefubItem;    
    [SerializeField] private GameObject parentForInventorySlot;
    private List<InventaryType> list;

    private void Awake()
    {
        list = new List<InventaryType>();
    }
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
        
        list.Add(inventorySlot.type);       
    }

    public bool YesHummer()
    {
        if(list.Count > 0)
        {
            return list.Contains(InventaryType.hummer);
        }
        else return false;
    
    }
}
