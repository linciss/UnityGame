using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectDragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler,
    IDragHandler, IEndDragHandler
{

    public Canvas canvas;
    private RectTransform rect;
    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pressed on an object");
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Started dragging");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("In process");
        rect.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Ended dragging");
    }
}
