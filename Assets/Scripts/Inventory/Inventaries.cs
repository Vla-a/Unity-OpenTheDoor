using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventaries : MonoBehaviour
{

    public List<InventaryType> inventaryTypes;
    void Start()
    {
       
        GameController.Instance.Inventary += AddPickables;
        inventaryTypes = new List<InventaryType>();
    }
    public void AddPickables(InventaryType inventaryType)
    {      
        inventaryTypes.Add(inventaryType);        
    }
 
    private void OnDestroy()
    {
        GameController.Instance.Inventary -= AddPickables;
    }

}
