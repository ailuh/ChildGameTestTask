using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PressedButtonDown : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool buttonPressed;
    [SerializeField] RectTransform _scrollRect;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }

    private void Update()
    {
        if (buttonPressed)
        {
            _scrollRect.localPosition += new Vector3(0, 50, 0);
        }
    }
}
