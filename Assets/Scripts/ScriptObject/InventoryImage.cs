using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

[CreateAssetMenu(menuName = "ScriptableObjects/InventoryImage")]

public class InventoryImage : ScriptableObject
{
    [SerializeField] private ItemsField[] itemImages;

    public Sprite GetItemByType(InventaryType inventaryType)
    {
        return itemImages.First(x => x.inventaryType == inventaryType).image;
    }   

}
public enum InventaryType { key, hummer }

[Serializable]
public class ItemsField
{
    public InventaryType inventaryType;
    public Sprite image;
}
