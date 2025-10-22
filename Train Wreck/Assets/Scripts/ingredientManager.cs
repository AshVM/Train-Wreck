using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class ingredientManager : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public string ingredientName;
    public RectTransform rectTransform;
    public Canvas canvas;
    private Vector2 ogPos;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        ogPos = rectTransform.anchoredPosition;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
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



        if (target != null && target.CompareTag("DropTarget"))
        {
            target.GetComponent<dropTarget>().OnItemDropped(ingredientName);
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    
}
