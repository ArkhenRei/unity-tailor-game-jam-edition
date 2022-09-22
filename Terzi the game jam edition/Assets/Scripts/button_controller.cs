using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_controller : MonoBehaviour
{
    [SerializeField] GameObject StartGame;
    [SerializeField] GameObject EndGame;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject needle;
    public GameObject moneyCT;
    

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
            moneyCT.GetComponent<MoneyCT>().score = 2;
        }
        else if (needle.GetComponent<needle_controller>().qua == "average")
        {
            moneyCT.GetComponent<MoneyCT>().score = 1;
        }
        else if (needle.GetComponent<needle_controller>().qua == "bad")
        {
            moneyCT.GetComponent<MoneyCT>().score = 0;
        }
        Time.timeScale = 1f;
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
    }
}
