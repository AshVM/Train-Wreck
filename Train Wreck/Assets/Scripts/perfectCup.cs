using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class perfectCup : MonoBehaviour
{
    [SerializeField] GameObject coffeeBag;
    [SerializeField] GameObject filter;
    [SerializeField] GameObject sugar;
    [SerializeField] GameObject machine;
    [SerializeField] GameObject milk;
    [SerializeField] GameObject mug;

    public bool mouseOcc;
    public int clicks;

    

    /* Plan(pseudocode) for the script:
     * find mouse position
     * if mouse position is within 
     * 
     *        1. assign each item but the mug the tag 'not water' -> assign mug 'water' tag
     *          if assigned 'not water' and clickOnObject == true
     *              return message 'that isnt the correct order
     *              return not water object to og pos
     *          else if assigned 'water' and clickOnObject == true
     *              if object == coffee machine 
     *                  change coffee machine sprite -> filled with water
     *                  change mug sprite -> empty mug
     *                  replace each item but coffee powder's tag with 'not powder' -> assign powder 'powder' tag
     *              else
     *                  return message 'those dont go together'
     *         2. after assigning powder tags:
     *              if assigned 'not powder' and clickOnObject == true
     *                  return message 'that isn't the correct order'
     *                  return object to og Pos
     *              yada yada ^^^ will make above a function so i dont have to write this multiple times
     *              
     *          
     *           
     * 
     * 
     */


    // Start is called before the first frame update
    void Start()
    {
        clicks = 0;
        mouseOcc = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("water"))
        {
            if (mug.gameObject.GetComponent<mugScript>().waterSelected)
            {
                coffeeBag.GetComponent<followMouse3>().enabled = false;
                sugar.GetComponent<followMouse3>().enabled = false;
                milk.GetComponent<followMouse3>().enabled = false;
                filter.GetComponent<followMouse3>().enabled = false;

            }
            
            
        }
        
        
    }
}
