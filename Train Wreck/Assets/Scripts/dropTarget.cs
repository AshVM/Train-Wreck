using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dropTarget : MonoBehaviour, IDropHandler
{
    public GameManager gameManager;

    
    public void OnDrop(PointerEventData eventData)
    {

        // dropped ingredient <- obtained from pointer info
        GameObject droppedObject = eventData.pointerDrag;
        Debug.Log("Dropped Object: " + droppedObject.name);

        //failsafe 
        if (droppedObject == null)
        {
            return;
        }


        ingredientManager IngredientManager = droppedObject.GetComponent<ingredientManager>();
        IngredientManager.parentAfterDrag = transform;
        
        // gives the game manager the name of the dropped ingredient
        gameManager.HandleIngredientDrop(droppedObject.name);
    }
 
}
