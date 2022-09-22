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
    public TextMeshProUGUI EarnedMoney;
    public TextMeshProUGUI TotalMoney;
    public TextMeshProUGUI Expense;
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
                endDay();
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
        GetComponent<MoneyCT>().cust = 1;
        NextDay.SetActive(false);
        GetComponent<MoneyCT>().earned = 0;
        GetComponent<MoneyCT>().earnToday = 0;
        GetComponent<MoneyCT>().expense = 0;
        GetComponent<MoneyCT>().usedRope = 0;
        GetComponent<MoneyCT>().usedFabric = 0;
        
    }
    public void endDay()
    {
        NextDay.SetActive(true);
        GetComponent<MoneyCT>().expense = GetComponent<MoneyCT>().usedFabric * 15 + GetComponent<MoneyCT>().usedRope * 10 + 25;
        GetComponent<MoneyCT>().earnToday = GetComponent<MoneyCT>().expense + GetComponent<MoneyCT>().earned;
        GetComponent<MoneyCT>().totalMoney = GetComponent<MoneyCT>().totalMoney + GetComponent<MoneyCT>().earned;
        TotalMoney.text = "Total Money=" + GetComponent<MoneyCT>().totalMoney.ToString();
        Expense.text = "Expense =" + GetComponent<MoneyCT>().expense.ToString();
        EarnedMoney.text = "Earned Today=" + GetComponent<MoneyCT>().earnToday.ToString();
    }
}
