using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int recipeStep = 0;
    private string[] recipe = { "Cup", "Filter", "Coffee", "Sugar", "Sugar", "Sugar", "Sugar", "Sugar", "Milk", "Milk" };

    public void HandleIngredientDrop(string ingredient)
    {
        Debug.Log("Recipe Step: " + recipeStep);

        // checks if recipe is complete
        if (recipeStep >= recipe.Length)
        {
            Debug.Log("Recipe already completed.");
            // add transition to win scene here
            SceneManager.LoadScene("WinScene");
            return;
           
        }

        if (ingredient == recipe[recipeStep])
        {
            recipeStep++;
            Debug.Log("Correct ingredient added: " + ingredient);
            Debug.Log("Recipe Step: " + recipeStep);
            // checks if all steps are completed via the array
            if (recipeStep == recipe.Length)
            {
                Debug.Log("Recipe completed!");
                // REMINDER: Put transition to win scene here
                SceneManager.LoadScene("WinScene");
                return;
            }
            /*else
            {
                Debug.Log("These ingredients don't go together!");
                return;
            }*/

        }

        else
        {
            Debug.Log("Incorrect ingredient: " + ingredient + ". Expected: " + recipe[recipeStep]);
            return;
        }
    }

}
