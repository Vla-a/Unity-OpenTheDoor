using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageActive : MonoBehaviour , Interaction
{
    public TypeNumber typeItem;

    private void Start()
    {
        
    }
    public void Interract()
    {        
        GameController.Instance.PickObject(typeItem);        
        Destroy(gameObject);        
    }
}

 public enum TypeNumber
{
    NumberOne,
    NumberTwo,
}
