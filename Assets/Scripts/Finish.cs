using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject panelFinish;

    [SerializeField]
    private InputField nameUser;

    [SerializeField]
    private Text time;
     

    public void Salve()
    {
        print(nameUser.text);
        panelFinish.gameObject.SetActive(false);


        for(int cont = 1; cont < 6; cont++)
        {
            string rank = PlayerPrefs.GetString("rank-" + cont);

            print(rank);

            if (string.IsNullOrEmpty(rank) || MenorTempo(rank))
            {
                print("menor: " + time.text);
                PlayerPrefs.SetString(("rank-" + cont), time.text);
                PlayerPrefs.SetString(("rank-name-" + cont), nameUser.text);
                break;
            }
        }

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene("menu");
    }

    private bool MenorTempo(string timeCompareSave){
        System.DateTime timeCheck = System.DateTime.Parse(time.text);
        System.DateTime timeCompare = System.DateTime.Parse(timeCompareSave);

        return (timeCheck < timeCompare) ? true : false;
    }

    public void Retry()
    { 
        panelFinish.gameObject.SetActive(false);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
