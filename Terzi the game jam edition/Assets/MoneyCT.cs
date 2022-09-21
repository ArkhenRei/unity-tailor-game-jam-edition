using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCT : MonoBehaviour
{
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
