using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    public event Action<string> OnDoorOpen;
    public event Action<InventaryType> Inventary;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    public void PickObject(string tag)
    {
        OnDoorOpen?.Invoke(tag);
       
    }

    public void PikOb(InventaryType inventary)
    {
        Inventary?.Invoke(inventary);
    }

}