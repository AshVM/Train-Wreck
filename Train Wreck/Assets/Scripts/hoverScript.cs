using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverScript : MonoBehaviour
{
    [SerializeField] Sprite ogSprite;
    [SerializeField] Sprite highlightSprite;

    private void OnMouseOver()
    {
        transform.GetComponent<SpriteRenderer>().sprite = highlightSprite;
    }

    private void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().sprite = ogSprite;
    }
}
