using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int recipeStep = 0;
    private string[] recipe = { "Cup", "Filter", "Coffee", "Sugar", "Milk" };

    public void HandleIngredientDrop(string ingredient)
    {
        // checks if recipe is complete
        if (recipeStep >= recipe.Length)
        {
            Debug.Log("Recipe already completed.");
            // add transition to win scene here
            return;
           
        }

        if (ingredient == recipe[recipeStep])
        {
            recipeStep++;
            Debug.Log("Correct ingredient added: " + ingredient);

            // checks if all steps are completed via the array
            if (recipeStep == recipe.Length)
            {
                Debug.Log("Recipe completed!");
                // REMINDER: Put transition to win scene here
            }
            else
            {
                Debug.Log("These ingredients don't go together!");
            }

        }
    }

}
