using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_controller : MonoBehaviour
{
    [SerializeField] GameObject StartGame;
    [SerializeField] GameObject EndGame;
    public GameObject iron;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject needle;
    public GameObject moneyCT;
    public GameObject machine;
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startGame()
    {
        StartGame.SetActive(false);
        Time.timeScale = 1f;
    }
    public void endGame()
    {
        if (needle.GetComponent<needle_controller>().qua == "good")
        {
            if (iron.GetComponent<IronCt>().canIron == false)
            {
                moneyCT.GetComponent<MoneyCT>().earned += 15;
            }
            else if (iron.GetComponent<IronCt>().canIron == true)
            {
                moneyCT.GetComponent<MoneyCT>().earned += 5;
            }
        }
        else if (needle.GetComponent<needle_controller>().qua == "average")
        {
            if (iron.GetComponent<IronCt>().canIron == false)
            {
                moneyCT.GetComponent<MoneyCT>().earned += 5;
            }
            else if (iron.GetComponent<IronCt>().canIron == true)
            {
                moneyCT.GetComponent<MoneyCT>().earned += -5;
            }
        }
        else if (needle.GetComponent<needle_controller>().qua == "bad")
        {
            moneyCT.GetComponent<MoneyCT>().earned += -5;
        }
        machine.GetComponent<machineCT>().button.SetActive(false);
        machine.GetComponent<machineCT>().canPlay = false;
        moneyCT.GetComponent<MoneyCT>().DidFabric = false;


        Time.timeScale = 1f;
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
    }
}
