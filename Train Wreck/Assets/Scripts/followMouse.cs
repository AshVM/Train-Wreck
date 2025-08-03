using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class followMouse : MonoBehaviour, IPointClickHandler
{
    [SerializeField] Vector3 ogPos;

    Vector3 pos;

    public float speed = 1.0f;
    public float horizontalDis = 0f;
    public float verticalDis = 0f;
    public int counter;
    public bool clicked = false;


   private void OnMouseDown()
    {

       clicked = true;
        
    }

    //public void OnPointerClick()
    //{
        //counter++;
    //}

    private void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {

      /*if (clicked && counter <= 1)
      {
            pos.x = Input.mousePosition.x - horizontalDis;
            pos.y = Input.mousePosition.y - verticalDis;
            pos.z = speed;

            transform.position = Camera.main.ScreenToWorldPoint(pos);

            counter = 1;
      }
      else if (clicked && counter > 1)
      {
            transform.position = ogPos;
            counter = 0;
      }*/

      if (clicked)
      {

            counter++;
            if (counter == 1)
            {
                counter++;

                pos.x = Input.mousePosition.x - horizontalDis;
                pos.y = Input.mousePosition.y - verticalDis;
                pos.z = speed;

                transform.position = Camera.main.ScreenToWorldPoint(pos);
            }
            else if (counter > 1)
            {
                clicked = false;
                counter = 0;
                transform.position = ogPos;
            }

        }
      else
        {
            transform.position = ogPos;
        }

        


    }

   
}
