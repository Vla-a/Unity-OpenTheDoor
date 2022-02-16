using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovePazzle: MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private Canvas parentCanvas;
    [SerializeField] private GameObject finishItem;
    [SerializeField] private float errorRadius;
    private Vector3 startPosition;
    private RectTransform canvasRect;
    private RectTransform rect;
    private Camera UICamera;
    private Vector2 canvasBounds;

    private void Awake()
    {
        canvasRect = parentCanvas.GetComponent<RectTransform>();
        rect = GetComponent<RectTransform>();
        UICamera = parentCanvas.worldCamera;
        canvasBounds = new Vector2(canvasRect.sizeDelta.x / 2 - rect.sizeDelta.x  / 2, canvasRect.sizeDelta.y / 2 - rect.sizeDelta.y  / 2);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRect, eventData.position, UICamera, out Vector2 localPos);
        localPos.x = Mathf.Clamp(localPos.x, -canvasBounds.x, canvasBounds.x);
        localPos.y = Mathf.Clamp(localPos.y, -canvasBounds.y, canvasBounds.y);
        rect.anchoredPosition = localPos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        if (Vector3.Distance(gameObject.transform.position, finishItem.transform.position) <= errorRadius)
        {
            gameObject.transform.position = finishItem.transform.position;
            GetCode.AddElement();
        }
        else
        {
            gameObject.transform.position = startPosition;
        }
    }
}
