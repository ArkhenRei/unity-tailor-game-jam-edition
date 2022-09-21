using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCT : MonoBehaviour
{
    public string[] clothes = new string[3];
    public string[] colours = new string[4];
    public GameObject Fabric;
    public GameObject Rope;
    public int totalMoney;
    public int earnToday;
    public int expense;
    public bool needFabric;
    public bool needRope;
    public int usedRope;
    public int usedFabric;
    public bool delik;
    public int random;
    public int cust=0;
    public int current;
    public bool isChose;
    public GameObject gameCT;
    public int day=0;

    // Start is called before the first frame update
    void Start()
    {
        clothes[0] = "Ceket";
        clothes[1] = "hayalet";
        clothes[2] = "pantolon";
        colours[0] = "mavi";
        colours[1] = "pembe";
        colours[2] = "sari";
        colours[3] = "yesil";
    }

    // Update is called once per frame
    void Update()
    {
        current = gameCT.GetComponent<GameCT>().currenCust;
        if (current != cust && isChose)
        {
            isChose = false;
            cust++;
        }
        if (cust>0 && isChose == false)
        {
            random = Random.Range(0, 1);
            if (random > 0)
            {
                needFabric = true;
                needRope = true;
                
            }
            else
            {
                needFabric = false;
                needRope = true;
            }


        }
        if (day != gameCT.GetComponent<GameCT>().day)
        {
            expense = usedRope * 10 + usedFabric * 15;
            totalMoney = totalMoney - expense;
        }
        
    }
}
