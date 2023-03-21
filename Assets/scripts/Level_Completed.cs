using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level_Completed : MonoBehaviour
{
    public GameObject level_completed_panel;
    public Lift end_lift;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            level_completed_panel.SetActive(true);
            collision.gameObject.GetComponent<Player>().move_speed = 0f;
            collision.gameObject.GetComponent<Player>().jump_force = 0f;
            end_lift.move_speed = 0f;
        }
    }
}
