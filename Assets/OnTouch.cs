using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnTouch : MonoBehaviour,IPointerClickHandler,IPointerDownHandler
{
    public int dir;

    public void OnPointerClick(PointerEventData eventData)
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("damm");
        Player._instance.Move(dir);
    }
}
