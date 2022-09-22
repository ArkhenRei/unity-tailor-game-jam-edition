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
    // Start is called before the first frame update
    public void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    public void Update()
    {
        if (gameObject.GetComponent<SpriteRenderer>().sprite == highlight && canPlay== false)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = normal;
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (!MoneyCT.GetComponent<MoneyCT>().isScore)
            {
                if (MoneyCT.GetComponent<MoneyCT>().score ==2)
                {
                    MoneyCT.GetComponent<MoneyCT>().score = 1;
                }
                else if (MoneyCT.GetComponent<MoneyCT>().score ==1 || MoneyCT.GetComponent<MoneyCT>().score ==0)
                {
                    MoneyCT.GetComponent<MoneyCT>().score = 0;
                }
            }
            start.SetActive(false);
            button.SetActive(false);
            isCompleted = true;
        }
    }
   
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "fabric" && MoneyCT.GetComponent<customer>().needFabric)
        {
            MoneyCT.GetComponent<MoneyCT>().DidFabric = true;
            MoneyCT.GetComponent<MoneyCT>().usedFabric++;
            gameObject.GetComponent<SpriteRenderer>().sprite = highlight;
            canPlay = true;
            button.SetActive(true);
            
        }
        if (collision.gameObject.tag == "rope" && MoneyCT.GetComponent<customer>().needFabric && MoneyCT.GetComponent<customer>().needRope)
        {
            MoneyCT.GetComponent<MoneyCT>().DidRope = true;
            MoneyCT.GetComponent<MoneyCT>().usedRope++;
            gameObject.GetComponent<SpriteRenderer>().sprite = highlight;
            canPlay = true;
            button.SetActive(true);

        }

    }


    public void startmachineCoats()
    {
        if (MoneyCT.GetComponent<customer>().RandClot ==0)
        {
            MoneyCT.GetComponent<customer>().cType = true;
        }
       
        start.SetActive(true);
        button.SetActive(false);
    }

    public void startmachineSweaters()
    {
        if (MoneyCT.GetComponent<customer>().RandClot == 3)
        {
            MoneyCT.GetComponent<customer>().cType = true;
        }
        if (!MoneyCT.GetComponent<customer>().cType && iron.GetComponent<IronCt>().canIron)
        {
            MoneyCT.GetComponent<MoneyCT>().score =0;
            isCompleted = true;
           
        }
        else if (!MoneyCT.GetComponent<customer>().cType || iron.GetComponent<IronCt>().canIron)
        {
            start.SetActive(true);
            button.SetActive(false);
            MoneyCT.GetComponent<MoneyCT>().isScore = false;
        }
        else if (MoneyCT.GetComponent<customer>().cType && iron.GetComponent<IronCt>().canIron == false)
        {
            start.SetActive(true);
            button.SetActive(false);
            MoneyCT.GetComponent<MoneyCT>().isScore = true;
        }
      
    }
    public void startmachinePants()
    {
        if (MoneyCT.GetComponent<customer>().RandClot == 2)
        {
            MoneyCT.GetComponent<customer>().cType = true;
        }
        start.SetActive(true);
        button.SetActive(false);
    }
    public void startmachineCostumes()
    {
        if (MoneyCT.GetComponent<customer>().RandClot == 1)
        {
            MoneyCT.GetComponent<customer>().cType = true;
        }
        start.SetActive(true);
        button.SetActive(false);
    }
    public void startmachineTshirts()
    {
        if (MoneyCT.GetComponent<customer>().RandClot == 4)
        {
            MoneyCT.GetComponent<customer>().cType = true;
        }
        start.SetActive(true);
        button.SetActive(false);
    }
    public void startmachineHoodies()
    {
        if (MoneyCT.GetComponent<customer>().RandClot == 5)
        {
            MoneyCT.GetComponent<customer>().cType = true;
        }
        start.SetActive(true);
        button.SetActive(false);
    }
}
