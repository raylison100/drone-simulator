using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public GameObject panelLose;

    public void Retry()
    { 
        panelLose.gameObject.SetActive(true);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void Quit()
    {
        SceneManager.LoadScene("menu");
    }
}   
