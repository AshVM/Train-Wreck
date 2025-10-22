using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ingredientManager : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public string ingredientName;
    public RectTransform rectTransform;
    public Transform parentAfterDrag;
    public Canvas canvas;
    private Vector2 ogPos;
    private Image image;
    public GameObject ingredient;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        ogPos = rectTransform.anchoredPosition;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image = GetComponent<Image>();
        image.raycastTarget = false;
        Debug.Log("image.raycastTarget:" + image.raycastTarget);
    }

    public void OnDrag(PointerEventData eventData)
    {
       rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        Debug.Log("OnDrag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GameObject target = eventData.pointerEnter;

        rectTransform.anchoredPosition = ogPos;

        Debug.Log("OnEndDrag");

        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
        Debug.Log("image.raycastTarget:" + image.raycastTarget);
        Debug.Log("Pointer's Current Raycast:" + eventData.pointerCurrentRaycast.gameObject.name);



        if (target != null && target.CompareTag("DropTarget"))
        {
           // target.GetComponent<dropTarget>().OnItemDropped(ingredientName);
            
        }
    }
   

    
}
