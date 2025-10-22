using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dropTarget : MonoBehaviour, IDropHandler
{
    public GameManager gameManager;

    

   /* public void OnItemDropped(string ingredientName)
    {
        gameManager.HandleIngredientDrop(ingredientName);
    }*/
   
    public void OnDrop(PointerEventData eventData)
    {
        GameObject droppedObject = eventData.pointerDrag;
        if (droppedObject == null)
        {
            return;
        }

        ingredientManager IngredientManager = droppedObject.GetComponent<ingredientManager>();
        IngredientManager.parentAfterDrag = transform;
        Debug.Log("OnDrop");
    }
 
}
