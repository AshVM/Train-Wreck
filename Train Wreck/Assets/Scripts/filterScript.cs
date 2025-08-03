using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class filterScript : MonoBehaviour
{
    public machineScript MachineScript;

    [SerializeField] GameObject coffeBag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (coffeBag.GetComponent<followMouse>().enabled )
        {
            
        }
    }
}
