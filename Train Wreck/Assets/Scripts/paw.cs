using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paw : MonoBehaviour
{
    // script to make paw follow mouse
    Vector3 pos;
    
    public float speed = 1f;
    public float horizontalDis = 0f;
    public float verticalDis = 0f;


    // Update is called once per frame
    void Update()
    {
        // paws x position, use horizontal distance to put distance between paw and mouse
        pos.x = Input.mousePosition.x - horizontalDis;

        // paws y position: use vertical distance for same purpose
        pos.y = Input.mousePosition.y - verticalDis;

        // paws z position
        pos.z = speed;
        transform.position = Camera.main.ScreenToWorldPoint(pos);

        Cursor.visible = false;
    }
}
