using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public bool Final_level = false;
    public int Next_scene_Index;
    public void On_click_Play()
    {
        SceneManager.LoadScene(1);
    }
    public void On_click_Quit()
    {
        Application.Quit();
    }
    public void On_click_Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void On_click_Next_level()
    {
        if (Final_level == true)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(Next_scene_Index);
        }
    }
}
