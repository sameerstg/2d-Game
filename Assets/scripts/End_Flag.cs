using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class End_Flag : MonoBehaviour
{
    public bool Final_level;
    public string Next_scene_Name;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Final_level)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                SceneManager.LoadScene(Next_scene_Name);
            }
        }
    }
}
