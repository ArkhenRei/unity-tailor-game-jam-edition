using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenCT : MonoBehaviour
{
    private static screenCT instance = null;

    public static int day = 1;
    public static int Totalmoney = 0;
    public static int maxDay = 3;
    public static int maxCustomer = 5;
    public static int currentCustomer = 1;
    public static int earnedToday = 0;

    public static bool didIron = false;
    public static bool didFabric = false;
    public static bool didPlay = false;
    public static bool didTalk = false;
    public static bool isNextDay = false;
    public static bool canIron = true;
    public static bool play = false;
    [SerializeField] GameObject minpref;



    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    private void Update()
    {
        if (currentCustomer>5)
        {
            currentCustomer = 0;
            day++;
            isNextDay = true;
        }
        if (play)
        {
            Instantiate(minpref);
        }
    }

 
   
    public static void nextCustomer()
    {
        currentCustomer++;
        didFabric = false;
        didIron = false;
        didPlay = false;
        didTalk = false;
        canIron = true;
        play = false;
        machineCT.rend.sprite = machineCT.normal;
        IronCt.rend.sprite = IronCt.normal;
       
    }



    public void close()
    {
        Application.Quit();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }


}
