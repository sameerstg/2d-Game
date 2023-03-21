using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 target_pos;
    private Vector3 start_pos;
    public GameObject game_over_panel;
    public float move_speed;
    private bool move_towards_target_pos;
    public Player player;
    public Lift lift;
    public Lift end_lift;
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
            game_over_panel.SetActive(true);
            player.move_speed = 0f;
            player.jump_force = 0f;
            player.spr.enabled = false;
            move_speed = 0f;
            lift.move_speed = 0f;
            end_lift.move_speed = 0f;
        }
    }
}
