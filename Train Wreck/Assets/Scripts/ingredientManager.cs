using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ingredientManager : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public string ingredientName;
    public GameObject ingredient;
    [HideInInspector] public Transform parentAfterDrag;


    private RectTransform rectTransform;
    private Canvas canvas;
    private Vector2 ogPos;
    private Image image;
   

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();

        // stores ingredient's original position
        ogPos = rectTransform.anchoredPosition;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // sets ingredient to be child of root so it appears on top of all other UI elements
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();

        // disable raycast while dragging so it doesn't block drop target's raycast
        image = GetComponent<Image>();
        image.raycastTarget = false;
        //Debug.Log("image.raycastTarget:" + image.raycastTarget);
    }

    public void OnDrag(PointerEventData eventData)
    {
        // follow pointer while dragging
       rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // check what the pointer is currently over
        GameObject target = eventData.pointerEnter;

        // return ingredient to original position
        rectTransform.anchoredPosition = ogPos;

        
        // sets ingredient back to its original parent (it wont be on top of all other UI elements anymore)
        transform.SetParent(parentAfterDrag);

        // re-enable ingredient's raycast
        image.raycastTarget = true;
        //Debug.Log("image.raycastTarget:" + image.raycastTarget);
        //Debug.Log("Pointer's Current Raycast:" + eventData.pointerCurrentRaycast.gameObject.name);



        if (target != null && target.CompareTag("DropTarget"))
        {
           // target.GetComponent<dropTarget>().OnItemDropped(ingredientName);
            
        }
    }
   

    
}
