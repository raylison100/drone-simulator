using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Principal : MonoBehaviour
{
    public GameObject panelMenu;
    public GameObject panelRank;

    public void  StartStage() 
    {
        SceneManager.LoadScene("stage01");
    }

    public void Rank()
    {
        panelMenu.gameObject.SetActive(false);
        panelRank.gameObject.SetActive(true);
    }

    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
