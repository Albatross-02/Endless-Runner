using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    
    public void Play(string Scene_Name)
    {
        SceneManager.LoadScene(Scene_Name);
    }


    public void Quit()
    {
        Application.Quit();
    }
   
}
