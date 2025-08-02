using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class dragAndDrop : MonoBehaviour
{
    [SerializeField] Vector3 ogPos;
    Vector3 pos;

    private float speed = 1f;
    private float horizontalDis = 0f;
    private float verticalDis = 0f;


    // Update is called once per frame
    void OnMouseDrag()
    {
       
        pos.x = Input.mousePosition.x - horizontalDis;

       
        pos.y = Input.mousePosition.y - verticalDis;

        
        pos.z = speed;
        transform.position = Camera.main.ScreenToWorldPoint(pos);

        
    }

    private void OnMouseUp()
    {
        transform.position = ogPos;
    }
}
