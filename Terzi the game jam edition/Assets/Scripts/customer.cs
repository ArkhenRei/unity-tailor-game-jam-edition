using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customer: MonoBehaviour
{
    public GameObject[] coats = new GameObject[8];
    public GameObject[] pants = new GameObject[8];
    public GameObject[] sweaters = new GameObject[8];
    public GameObject[] hoodies = new GameObject[8];
    public GameObject[] costumes = new GameObject[2];
    public GameObject[] tshirts = new GameObject[8];

    public bool needFabric;
    public bool needRope;
    public bool cType;

    public GameObject machine;
    public bool didComplete;

    public int RandClot;
    public int RandColo;



    private void Start()
    {

        cType = false;
        chooseClothes();
    }
    private void Update()
    {
        didComplete = machine.GetComponent<machineCT>().isCompleted;
        if (didComplete)
        {
            needRope = false;
            needFabric = false;
      
        }
    }
    public void chooseClothes()
    {
        cType = false;
        RandClot = Random.Range(0, 7);
        if (RandClot == 0)
        {
            RandColo = Random.Range(0, 4);
            if (RandColo == 0)
            {
                coats[0].SetActive(true);
                needFabric = true;
                needRope = true;
            }
            else if (RandColo == 1)
            {
                coats[2].SetActive(true);
                needFabric = true;
                needRope = true;
            }
            else if (RandColo == 2)
            {
                coats[4].SetActive(true);
                needFabric = true;
                needRope = true;
            }
            else if (RandColo == 3)
            {
                coats[6].SetActive(true);
                needFabric = true;
                needRope = true;
            }
        }
        else if (RandClot == 1)
        {
            RandColo = Random.Range(0, 4);
            if (RandColo == 0)
            {
                pants[0].SetActive(true);
                needFabric = true;
                needRope = true;
            }
            else if (RandColo == 1)
            {
                pants[2].SetActive(true);
                needFabric = true;
                needRope = true;
            }
            else if (RandColo == 2)
            {
                pants[4].SetActive(true);
                needFabric = true;
                needRope = true;
            }
            else if (RandColo == 3)
            {
                pants[6].SetActive(true);
                needFabric = true;
                needRope = true;
            }
        }
        else if (RandClot == 2)
        {
            RandColo = Random.Range(0, 4);
            if (RandColo == 0)
            {
                sweaters[0].SetActive(true);
                needFabric = true;
                needRope = true;
            }
            else if (RandColo == 1)
            {
                sweaters[2].SetActive(true);
                needFabric = true;
                needRope = true;
            }
            else if (RandColo == 2)
            {
                sweaters[4].SetActive(true);
                needFabric = true;
                needRope = true;
            }
            else if (RandColo == 3)
            {
                sweaters[6].SetActive(true);
                needFabric = true;
                needRope = true;
            }
        }
        else if (RandClot == 3)
        {
            RandColo = Random.Range(0, 4);
            if (RandColo == 0)
            {
                tshirts[0].SetActive(true);
                needFabric = true;
                needRope = true;
            }
            else if (RandColo == 1)
            {
                tshirts[2].SetActive(true);
                needFabric = true;
                needRope = true;
            }
            else if (RandColo == 2)
            {
                tshirts[4].SetActive(true);
                needFabric = true;
                needRope = true;
            }
            else if (RandColo == 3)
            {
                tshirts[6].SetActive(true);
                needFabric = true;
                needRope = true;
            }
        }
        else if (RandClot == 4)
        {
            RandColo = Random.Range(0, 4);
            if (RandColo == 0)
            {
                hoodies[0].SetActive(true);
                needFabric = true;
                needRope = true;
            }
            else if (RandColo == 1)
            {
                hoodies[2].SetActive(true);
                needFabric = true;
                needRope = true;
            }
            else if (RandColo == 2)
            {
                hoodies[4].SetActive(true);
                needFabric = true;
                needRope = true;
            }
            else if (RandColo == 3)
            {
                hoodies[6].SetActive(true);
                needFabric = true;
                needRope = true;
            }
        }
        else if (RandClot == 5)
        {
            costumes[0].SetActive(true);
            needFabric = true;
            needRope = true;

        }
    }

}
