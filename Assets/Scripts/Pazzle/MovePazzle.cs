using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovePazzle: MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    [SerializeField] private GameObject draggedItem;
    private Vector3 startPosition;
    private Transform startParent;

    public void OnBeginDrag(PointerEventData eventData)
    {
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;      
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (Mathf.Abs(transform.position.x - draggedItem.transform.position.x) <= 50f &&
    Mathf.Abs(transform.position.y - draggedItem.transform.position.y) <= 50f)
        {
            transform.position = draggedItem.transform.position;
            GetCode.AddElement();
        }
        else
            transform.position = startPosition;

    }
}
