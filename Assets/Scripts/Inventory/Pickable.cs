using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour, Interaction
{
    public InventaryType inventaryType;
    
    public void Interract()
    {        
        GameController.Instance.PikOb(inventaryType);
        Destroy(gameObject);
    }

    public void PickUp()
    {        
        //GameController.Instance.PikOb(inventaryType);
        //Destroy(gameObject);
    }
}
