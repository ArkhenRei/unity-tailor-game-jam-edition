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
    public GameObject fabric;
    

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
        fabric.GetComponent<fabric_controller>().speedHor = 25f;
        fabric.GetComponent<fabric_controller>().speedVer = 0.85f;


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
        foreach (var item in moneyCT.GetComponent<customer>().coats)
        {
            item.SetActive(false);
        }
        foreach (var item in moneyCT.GetComponent<customer>().pants)
        {
            item.SetActive(false);
        }
        foreach (var item in moneyCT.GetComponent<customer>().costumes)
        {
            item.SetActive(false);
        }
        foreach (var item in moneyCT.GetComponent<customer>().tshirts)
        {
            item.SetActive(false);
        }
        foreach (var item in moneyCT.GetComponent<customer>().sweaters)
        {
            item.SetActive(false);
        }
        foreach (var item in moneyCT.GetComponent<customer>().hoodies)
        {
            item.SetActive(false);
        }

        machine.GetComponent<machineCT>().isCompleted = true;
        fabric.GetComponent<fabric_controller>().sifirla();
        machine.GetComponent<machineCT>().button.SetActive(false);
        machine.GetComponent<machineCT>().canPlay = false;
        moneyCT.GetComponent<MoneyCT>().DidFabric = false;


        Time.timeScale = 1f;
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
    }
}
