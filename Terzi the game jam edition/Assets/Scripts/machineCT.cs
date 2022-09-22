using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machineCT : MonoBehaviour
{
    public GameObject start;
    public GameObject button;
    public GameObject MoneyCT;
    public GameObject iron;
    public Renderer rend;
    public Sprite highlight;
    public Sprite normal;
    public Color colorTurnTo = Color.white;
    public bool isCompleted = false;
    public bool canPlay;
    [SerializeField] GameObject[] myMinigames;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public int keepR;
    public GameObject startt;
    public GameObject exit;
    public GameObject bstartt;
    public GameObject bexit;
    public GameObject cstartt;
    public GameObject cexit;
    public GameObject startBut;
    public GameObject exitBut;
    public GameObject bstartBut;
    public GameObject bexitBut;
    public GameObject cstartBut;
    public GameObject cexitBut;

    // Start is called before the first frame update
    public void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    public void Update()
    {
        if (MoneyCT.GetComponent<MoneyCT>().DidFabric)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = highlight;
            canPlay = true;
            button.SetActive(true);
        }
        if (gameObject.GetComponent<SpriteRenderer>().sprite == highlight && canPlay== false)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = normal;
        }
       
    }
   
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "fabric" && MoneyCT.GetComponent<customer>().needFabric)
        {
            MoneyCT.GetComponent<customer>().needFabric = false;
            MoneyCT.GetComponent<MoneyCT>().DidFabric = true;
            MoneyCT.GetComponent<MoneyCT>().usedFabric++;
            MoneyCT.GetComponent<MoneyCT>().usedRope++;



        }

    }


    public void startmachineCoats()
    {
        keepR = Random.Range(0, 3);
        if (keepR ==0)
        {
            a.SetActive(true);
            startt.SetActive(true);
            exit.SetActive(false);
            startBut.SetActive(true);
            exitBut.SetActive(false);

        }
        else if (keepR ==1)
        {
            b.SetActive(true);
            bstartt.SetActive(true);
            bexit.SetActive(false);
            bstartBut.SetActive(true);
            bexitBut.SetActive(false);
        }
        else if (keepR == 2)
        {
            c.SetActive(true);
            cstartt.SetActive(true);
            cexit.SetActive(false);
            cstartBut.SetActive(true);
            cexitBut.SetActive(false);
        }
        if (MoneyCT.GetComponent<customer>().RandClot == 0)
         {
             MoneyCT.GetComponent<customer>().cType = true;
         }
       
    }

    public void startmachineSweaters()
    {
        keepR = Random.Range(0, 3);
        if (keepR == 0)
        {
            a.SetActive(true);
            startt.SetActive(true);
            exit.SetActive(false);
            startBut.SetActive(true);
            exitBut.SetActive(false);

        }
        else if (keepR == 1)
        {
            b.SetActive(true);
            bstartt.SetActive(true);
            bexit.SetActive(false);
            bstartBut.SetActive(true);
            bexitBut.SetActive(false);
        }
        else if (keepR == 2)
        {
            c.SetActive(true);
            cstartt.SetActive(true);
            cexit.SetActive(false);
            cstartBut.SetActive(true);
            cexitBut.SetActive(false);
        }
        if (MoneyCT.GetComponent<customer>().RandClot == 2)
        {
            MoneyCT.GetComponent<customer>().cType = true;
        }
    
    }
    public void startmachinePants()
    {
        keepR = Random.Range(0, 3);
        if (keepR == 0)
        {
            a.SetActive(true);
            startt.SetActive(true);
            exit.SetActive(false);
            startBut.SetActive(true);
            exitBut.SetActive(false);

        }
        else if (keepR == 1)
        {
            b.SetActive(true);
            bstartt.SetActive(true);
            bexit.SetActive(false);
            bstartBut.SetActive(true);
            bexitBut.SetActive(false);
        }
        else if (keepR == 2)
        {
            c.SetActive(true);
            cstartt.SetActive(true);
            cexit.SetActive(false);
            cstartBut.SetActive(true);
            cexitBut.SetActive(false);
        }
        if (MoneyCT.GetComponent<customer>().RandClot == 1)
        {
            MoneyCT.GetComponent<customer>().cType = true;
        }
     
    }
    public void startmachineCostumes()
    {
        keepR = Random.Range(0, 3);
        if (keepR == 0)
        {
            a.SetActive(true);
            startt.SetActive(true);
            exit.SetActive(false);
            startBut.SetActive(true);
            exitBut.SetActive(false);

        }
        else if (keepR == 1)
        {
            b.SetActive(true);
            bstartt.SetActive(true);
            bexit.SetActive(false);
            bstartBut.SetActive(true);
            bexitBut.SetActive(false);
        }
        else if (keepR == 2)
        {
            c.SetActive(true);
            cstartt.SetActive(true);
            cexit.SetActive(false);
            cstartBut.SetActive(true);
            cexitBut.SetActive(false);
        }
        if (MoneyCT.GetComponent<customer>().RandClot == 5)
        {
            MoneyCT.GetComponent<customer>().cType = true;
        }
      
    }
    public void startmachineTshirts()
    {
        keepR = Random.Range(0, 3);
        if (keepR == 0)
        {
            a.SetActive(true);
            startt.SetActive(true);
            exit.SetActive(false);
            startBut.SetActive(true);
            exitBut.SetActive(false);

        }
        else if (keepR == 1)
        {
            b.SetActive(true);
            bstartt.SetActive(true);
            bexit.SetActive(false);
            bstartBut.SetActive(true);
            bexitBut.SetActive(false);
        }
        else if (keepR == 2)
        {
            c.SetActive(true);
            cstartt.SetActive(true);
            cexit.SetActive(false);
            cstartBut.SetActive(true);
            cexitBut.SetActive(false);
        }
        if (MoneyCT.GetComponent<customer>().RandClot == 3)
        {
            MoneyCT.GetComponent<customer>().cType = true;
        }
       
    }
    public void startmachineHoodies()
    {
        keepR = Random.Range(0, 3);
        if (keepR == 0)
        {
            a.SetActive(true);
            startt.SetActive(true);
            exit.SetActive(false);
            startBut.SetActive(true);
            exitBut.SetActive(false);

        }
        else if (keepR == 1)
        {
            b.SetActive(true);
            bstartt.SetActive(true);
            bexit.SetActive(false);
            bstartBut.SetActive(true);
            bexitBut.SetActive(false);
        }
        else if (keepR == 2)
        {
            c.SetActive(true);
            cstartt.SetActive(true);
            cexit.SetActive(false);
            cstartBut.SetActive(true);
            cexitBut.SetActive(false);
        }
        if (MoneyCT.GetComponent<customer>().RandClot == 4)
        {
            MoneyCT.GetComponent<customer>().cType = true;
        }

    }
}
