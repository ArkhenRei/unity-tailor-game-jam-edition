using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCT : MonoBehaviour
{
   public GameObject[] portraits = new GameObject[5];
    public bool[] isPortraits = new bool[5];
    public string[] clothes = new string[3];
    public string[] colours = new string[4];
    public string[] hasartype = new string[3];
    public int[] sort = new int[5];

    public GameObject gameCT;
    public GameObject Fabric;
    public GameObject Rope;
    public GameObject machine;
    public GameObject iron;

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

    public bool isChose;
    public bool needFabric;
    public bool needRope;
    public bool delik;
    public bool didMachine;

    public Vector3 postn;


    // Start is called before the first frame update
    void Start()
    {
        cust = 1;
        clothes[0] = "Ceket";
        clothes[1] = "hayalet";
        clothes[2] = "pantolon";
        colours[0] = "mavi";
        colours[1] = "pembe";
        colours[2] = "sari";
        colours[3] = "yesil";
        hasartype[0] = "delik";
        hasartype[1] = "yirtik";
        hasartype[2] = "both";
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
        if (cust ==0)
        {
            cust = 1;
        }
        if (cust== 1)
        {
            portraits[sort[0]].SetActive(true);
            
            currentCust = 1;
        }
        if (cust > currentCust && cust <=5)
        {
            portraits[sort[cust-1]].SetActive(true);
            portraits[sort[cust-2]].SetActive(false);
            currentCust = cust;
        }

        
    }

    public void characterRandom()
    {
       
       

    }

    public void NextCustomer()
    {
        didMachine = machine.GetComponent<machineCT>().isCompleted;
        if (didMachine)
        {
            cust++;
            iron.GetComponent<IronCt>().canIron = true;
            machine.GetComponent<machineCT>().canPlay = false;
            machine.GetComponent<machineCT>().isCompleted = false;
        }
        
    }
}
