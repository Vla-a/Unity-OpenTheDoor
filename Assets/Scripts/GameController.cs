using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject inventary;
    private bool graet = false;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q) && !graet)
        {
            inventary.SetActive(true);
            graet = true;
        }
        else if(Input.GetKeyDown(KeyCode.Q) && graet)
            {
            inventary.SetActive(false);
            graet = false;
        }
            
    }
    //public static GameController Instance;
    //public event Action OnDoorOpen;

    //private void Awake()
    //{
    //    if (Instance == null)
    //        Instance = this;
    //}
    //public void PickObject()
    //{
    //    OnDoorOpen?.Invoke();
    //}

}