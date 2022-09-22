using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyCT : MonoBehaviour
{
   public GameObject[] portraits = new GameObject[5];
    public bool[] isPortraits = new bool[5];
    public int[] sort = new int[5];

    public GameObject gameCT;
    public GameObject Fabric;
    public GameObject Rope;
    public GameObject machine;
    public GameObject iron;

    public TextMeshProUGUI usedRopeG;
    public TextMeshProUGUI usedFabricG;

    public bool DidRope;
    public bool DidFabric;

    public int totalMoney;
    public int earnToday;
    public int expense;
    public int usedRope;
    public int usedFabric;
    public int day = 0;
    public int random;
    public int cust;
    public int currentCust;
    public int keepPort;
    public int earned;
    public int score;
    public bool isScore;
    public int keepMoney;

    public bool isChose;
    
    public bool delik;
    public bool didMachine;

    public Vector3 postn;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        expense = 0;
        earned = 0;
        totalMoney = 100;
        usedRope = 0;
        usedFabric = 0;
        cust = 1;
        
        
        
        for (int i = 0; i < 5; i++)
        {
            isPortraits[i] = false;
            
        }
        for (int i = 0; i < 5; i++)
        {
            sort[i] = i;

        }
        characterRandom();
    }

    // Update is called once per frame
    void Update()
    {
        usedFabricG.text = "Kullanilan Kumas: " + usedFabric.ToString();
        usedRopeG.text ="Kullanilan ip: " + usedRope.ToString();
        didMachine = machine.GetComponent<machineCT>().isCompleted;
        if (didMachine)
        {
            foreach (var item in portraits)
            {
                item.SetActive(false);
            }
        }
        if (cust ==0 && !didMachine)
        {
            cust = 1;
        }
        if (cust== 1 && !didMachine)
        {
            portraits[sort[0]].SetActive(true);
            
            currentCust = 1;
        }
        if (cust > currentCust && cust <=5 && !didMachine)
        {
            portraits[sort[cust-1]].SetActive(true);
            currentCust = cust;
        }

        
    }

    public void characterRandom()
    {
       
       

    }

    public void NextCustomer()
    {
        
        if (didMachine)
        {
            DidFabric = false;
            DidRope = false;
            cust++;
            iron.GetComponent<IronCt>().canIron = true;
            machine.GetComponent<machineCT>().canPlay = false;
            machine.GetComponent<machineCT>().isCompleted = false;
            GetComponent<customer>().chooseClothes();
        }
        
    }
}
