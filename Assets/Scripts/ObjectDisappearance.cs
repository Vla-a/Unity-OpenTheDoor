using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;


public class ObjectDisappearance : MonoBehaviour
{
    [SerializeField] private List<ImageActive> _imageAktive = new List<ImageActive>();   
    [SerializeField] private GameObject player;   
    private Animator _animator;

    private void Start()
    {
        GameController.Instance.OnDoorOpen += AddPos;
        _animator = GetComponent<Animator>();
    }

    private void OnDestroy()
    {
        GameController.Instance.OnDoorOpen -= AddPos;
    }

    private void AddPos(string tag)
    {
        switch (tag)
        {                
             case "NumberOne":
                {
                    Search(tag);
                    break;
                }
            case "NamberTwo":
                {
                    Search(tag);
                    break;
                }
        }        
    }

    private void Search(string tag)
    {        
        var script = _imageAktive.First(obj => obj.CompareTag(tag));
        script.ImageActiv();
    }
}
