using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCode : MonoBehaviour
{

    [SerializeField] private GameObject image;
    [SerializeField] private GameObject pazzle;
    [SerializeField] private GameObject passwordnamber;
    private int fullElement;
    public static int myElement;
    
    void Start()
    {
        fullElement = image.transform.childCount;
    }
    
    void Update()
    {
      if(fullElement == myElement)
        {
            passwordnamber.SetActive(true);
        }
    }

    public static void AddElement()
    {        
        myElement++;  
       
            
    }
}
