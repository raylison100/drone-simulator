using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rank : MonoBehaviour
{
    public GameObject panelMenu;
    public GameObject panelRank;


    [SerializeField]
    private Text primeiro;

    [SerializeField]
    private Text segundo;

    [SerializeField]
    private Text terceiro;

    [SerializeField]
    private Text quarto;

    [SerializeField]
    private Text quinto;

    void Start()
    {
        primeiro.text   = "1 - " + PlayerPrefs.GetString("rank-name-1") + " - " + PlayerPrefs.GetString("rank-1");
        segundo.text    = "2 - " + PlayerPrefs.GetString("rank-name-2") + " - " + PlayerPrefs.GetString("rank-2");
        terceiro.text   = "3 - " + PlayerPrefs.GetString("rank-name-3") + " - " + PlayerPrefs.GetString("rank-3");
        quarto.text     = "4 - " + PlayerPrefs.GetString("rank-name-4") + " - " + PlayerPrefs.GetString("rank-4");
        quinto.text     = "5 - " + PlayerPrefs.GetString("rank-name-5") + " - " + PlayerPrefs.GetString("rank-5");
    }

    public void Back()
    {
        panelMenu.gameObject.SetActive(true);
        panelRank.gameObject.SetActive(false);
    }
}
