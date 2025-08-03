using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mugScript : MonoBehaviour
{
    public perfectCup system;
    public bool waterSelected;


    // Start is called before the first frame update
    void Start()
    {
        
        waterSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("water"))
        {
            waterSelected = true;
            system.mouseOcc = true;
            system.clicks++;
            //gameObject.GetComponent<followMouse2>().enabled = true;
        }

        if (system.clicks > 1)
        {
            //gameObject.GetComponent <followMouse2>().counter = 2;
        }
    }
}
