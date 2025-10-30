using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coffeeProgress : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI progressText;
    [SerializeField] float progress;
    public GameManager gameManager;

    private void Start()
    {
        progress = (gameManager.recipeStep) / (gameManager.recipe.Length) * (100);
    }

    // Update is called once per frame
    void Update()
    {
        progress = (float) gameManager.recipeStep / gameManager.recipe.Length * 100f;
        progressText.text = "Progress: " + progress + "%";

        Debug.Log("Progress: " + progress + ", RecipeStep: "+ gameManager.recipeStep + ", RecipeLength: " + gameManager.recipe.Length);
    }
}
