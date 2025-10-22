using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropTarget : MonoBehaviour
{
    public string targetName;
    public GameManager gameManager;

    public void OnItemDropped(string ingredientName)
    {
        gameManager.HandleIngredientDrop(targetName, ingredientName);
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
