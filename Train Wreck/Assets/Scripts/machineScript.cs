using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class machineScript : MonoBehaviour
{
    [SerializeField] Sprite newSprite;
    public mugScript MugScript;
    public perfectCup system;
    public bool waterInMachine;
   
    
    [SerializeField] TextMeshProUGUI text1;
    [SerializeField] TextMeshProUGUI text2;
    [SerializeField] TextMeshProUGUI text3;
    [SerializeField] TextMeshProUGUI text4;
    [SerializeField] TextMeshProUGUI text5;

    [SerializeField] GameObject coffeeBag;
    [SerializeField] GameObject filter;
    [SerializeField] GameObject sugar;
    [SerializeField] GameObject machine;
    [SerializeField] GameObject milk;
    [SerializeField] GameObject mug;

    // Start is called before the first frame update
    void Start()
    {
        waterInMachine = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
       /* if (gameObject.CompareTag("water"))
        {
            if (MugScript.waterSelected)
            {
                waterInMachine = true;
                transform.GetComponent<SpriteRenderer>().sprite = newSprite;
            }
            else if (system.mouseOcc)
            {

            }
        }*/

        if (MugScript.waterSelected)
        {
            coffeeBag.gameObject.GetComponent<followMouse2>().enabled = true;
            //MugScript.waterSelected = false;
            Destroy( text1 );
            text2.enabled = true;
            mug.gameObject.transform.GetComponent<SpriteRenderer>().sprite = newSprite;
            mug.gameObject.GetComponent<hoverScript>().enabled = false;
            mug.gameObject.GetComponent<followMouse2>().enabled = false;
            
            
        }
        
    }
}
