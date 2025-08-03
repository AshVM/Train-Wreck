using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse2 : MonoBehaviour
{
    [SerializeField] Vector3 ogPos;

    public int counter;

    Vector3 pos;

    private float speed = 1f;
    private float horizontalDis;
    private float verticalDis;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        counter++;
    }

    private void Start()
    {
        counter = 0;
    }
    // Update is called once per frame
    void Update()
    {
        if (counter == 0)
        {
            transform.position = ogPos;
        }
        else if(counter == 1)
        {
            pos.x = Input.mousePosition.x - horizontalDis;
            pos.y = Input.mousePosition.y - verticalDis;
            pos.z = speed;

            transform.position = Camera.main.ScreenToWorldPoint(pos);
        }
        else if (counter > 1)
        {
            counter = 0;
            transform.position = ogPos;
        }
    }
}
