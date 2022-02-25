using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class ObjectDisappearance : MonoBehaviour
{
    [SerializeField] private List<GameObject> _imageAktive;  
  
    private Animator _animator;

    private void Start()
    {
        GameController.Instance.ImageVisible += AddPos;
        _animator = GetComponent<Animator>();
    }

    private void OnDestroy()
    {
        GameController.Instance.ImageVisible -= AddPos;
    }

    private void AddPos(TypeNumber type)
    {
        switch (type)
        {                
             case TypeNumber.NumberOne:
                {
                    _imageAktive[0].active = true;
                    break;
                }
            case TypeNumber.NumberTwo:
                {
                    _imageAktive[1].active = true;
                    break;
                }
        }        
    }
}
