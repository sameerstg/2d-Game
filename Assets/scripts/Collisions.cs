using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public Player player;
    public GameObject game_over_panel;
    public Lift lift;
    public Lift end_lift;
    public Enemy enemy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            game_over_panel.SetActive(true);
            player.move_speed = 0f;
            player.jump_force = 0f;
            player.spr.enabled = false;
            player.rb_2d.simulated = false;
            lift.move_speed = 0f;
            end_lift.move_speed = 0f;
            enemy.move_speed = 0f;
        }
    }
}
