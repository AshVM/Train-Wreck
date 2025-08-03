using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse3 : MonoBehaviour
{
    [SerializeField] Vector3 ogPos;
    [SerializeField] Collider2D myCollider;

    public int counter;

    Vector3 pos;

    private float speed = 1f;
    private float horizontalDis;
    private float verticalDis;

    private void OnMouseEnter()
    {
        Debug.Log(gameObject.name + " detected!!!");
    }


    private void OnMouseDown()
    {
        counter++;
        if (counter > 1)
        {
            counter = 0;
            transform.position = ogPos;
            // myCollider.enabled = true;
        }
    }

    private void Start()
    {
        counter = 0;

    }
    // Update is called once per frame
    void Update()
    {

        // if not clicked keep at og position
        if (counter == 0)
        {
            transform.position = ogPos;
            myCollider.enabled = true;
        }
        // if clicked ONCE follow mouse
        else if (counter == 1)
        {
            pos.x = Input.mousePosition.x - horizontalDis;
            pos.y = Input.mousePosition.y - verticalDis;
            pos.z = speed;


            transform.position = Camera.main.ScreenToWorldPoint(pos);
            myCollider.enabled = false;
        }
        // if clicked a SECOND time return to OG pos
        else if (counter > 1)
        {
            counter = 0;
            transform.position = ogPos;
           // myCollider.enabled = true;
        }


    }
}
