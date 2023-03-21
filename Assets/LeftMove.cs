using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftMove : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{

    bool ispressed = false;
    public GameObject player;
    public float force;
    private bool isPressed;
    



    // Update is called once per frame
    void Update()
    {
        if (ispressed)
        {
            player.transform.Translate(force * Time.deltaTime, 0, 0);
        }
           
    }

    public void OnPointerDown(PointerEventData pointerEvent)
    {

        isPressed = true;
    }

    public void OnPointerUp(PointerEventData pointerEvent)
    {

        isPressed = false;
    }
}
