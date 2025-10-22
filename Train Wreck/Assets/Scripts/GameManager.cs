using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int recipeStep = 0;
    private string[] recipe = { "Cup", "Coffee", "Sugar", "Milk" };

    public void HandleIngredientDrop(string target, string ingredient)
    {
        // checks if recipe is complete
        if (recipeStep >= recipe.Length)
        {
            Debug.Log("Recipe already completed.");
            return;
           
        }

        if (target == recipe[recipeStep] && ingredient == recipe[recipeStep])
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
