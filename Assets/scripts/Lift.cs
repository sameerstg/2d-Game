using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    public Vector3 target_pos;
    private Vector3 start_pos;

    public float move_speed;
    private bool move_towards_target_pos;

    void Start()
    {
        start_pos = transform.position;
        move_towards_target_pos = true;
    }
    void Update()
    {
        if (move_towards_target_pos == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target_pos, move_speed * Time.deltaTime);

            if (transform.position == target_pos)
            {
                move_towards_target_pos = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, start_pos, move_speed * Time.deltaTime);

            if (transform.position == start_pos)
            {
                move_towards_target_pos = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(gameObject.transform);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
