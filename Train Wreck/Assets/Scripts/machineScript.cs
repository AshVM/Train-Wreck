using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machineScript : MonoBehaviour
{
    [SerializeField] Sprite newSprite;
    public mugScript MugScript;
    public perfectCup system;
    public bool waterInMachine;

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
        if (gameObject.CompareTag("water"))
        {
            if (MugScript.waterSelected)
            {
                waterInMachine = true;
                transform.GetComponent<SpriteRenderer>().sprite = newSprite;
            }
            else if (system.mouseOcc)
            {

            }
        }
        
    }
}
