using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class hoverScriptUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Sprite ogSprite;
    [SerializeField] private Sprite highlightSprite;

    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        image.sprite = highlightSprite;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.sprite = ogSprite;
    }

    
}
