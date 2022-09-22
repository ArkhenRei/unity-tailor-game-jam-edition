using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameCT : MonoBehaviour
{
    public int day = 0;
    public int maxCust = 5;
    public int currenCust = 0;
    public TextMeshProUGUI dayKeep;
    public GameObject NextDay;
    public GameObject money;
    public TextMeshProUGUI SpeechBubble;
    public GameObject panel;
    public string[] words = new string[10];
    public int sayac = 0;
    public GameObject machine;
    public GameObject iron;

    public bool Didİron =false;
    public bool DidMachine =false;
    public void Start()
    {

        

    }

    public void Update()
    {

        dayKeep.text = "Day" + " " + day.ToString();

        if (money.GetComponent<MoneyCT>().cust >5)
        {
            if (NextDay.activeSelf == false)
            {
                NextDay.SetActive(true);
            }

        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.SetActive(true);
        }
    }
    public void resumeA()
    {
        panel.SetActive(false);
    }
    public void exitA()
    {
        Application.Quit();
    }


   
    public void nextDayy()
    {
        day++;
        money.GetComponent<MoneyCT>().cust = 0;
        NextDay.SetActive(false);
    }
}
