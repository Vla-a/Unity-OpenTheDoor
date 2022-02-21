using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    [SerializeField] InventaryType inventary;  

    public void PickUp()
    {        
        GameController.Instance.PikOb(inventary);
        Destroy(gameObject);
    }
}
