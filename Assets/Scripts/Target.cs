using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public Material material;

    [SerializeField]
    private Text score;
    private int total = 5;

    public GameObject panelFinish;
    public GameObject panelLose;

    [SerializeField]
    private Text timeLevelText;
    private float timeLevel;

    private bool win;
    public static bool lose;
    
    void Start()
    {
        Time.timeScale = 1;
        panelFinish.gameObject.SetActive(false);
        score.text = total.ToString();

        win = false;
        lose = false;
    }

    void Update() {

        if(!win && !lose)
        {
            CountTime();    
        }

        if (lose)
        {
            Lose();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Target"))
        {
            AlterMaterial(col.gameObject);
            AlterScore();
        }
    }

    private void AlterMaterial(GameObject target)
	{
        Renderer rend = target.GetComponent<Renderer>();
        rend.sharedMaterial = material;
    }

    private void AlterScore()
    {
        total -= 1;
        score.text = total.ToString();

        if(total == 0){
            Finish();
        }
    }

    private void Pause()
    {
        Time.timeScale = 0;
    }

    private void Finish()
    {
        win = true;
        panelFinish.gameObject.SetActive(true);
        Pause();
    }

    private void CountTime()
    {
        timeLevel = timeLevel + Time.deltaTime;
        timeLevelText.text = FormatTime();
    }

    private string FormatTime() 
    {
        int  min = (int) timeLevel / 60;
        string mimText = (min < 10) ?  "0" + min : min.ToString();
    
        int  sec = (int) timeLevel % 60;
        string secText = (sec < 10) ? "0" + sec : sec.ToString();
   
        return mimText + " : " + secText;
    }

    private void Lose()
    {
        panelLose.gameObject.SetActive(true);
        Pause();
    }

}

