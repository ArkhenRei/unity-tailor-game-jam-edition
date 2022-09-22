using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customer: MonoBehaviour
{
    public GameObject[] clothesP = new GameObject[16];
    public string[] clothes = new string[3];
    public string[] colours = new string[4];
    public string[] hasartype = new string[4];
    public GameObject[] fiziksel = new GameObject[5];

    public GameObject machine;
    public bool didComplete;

    public int RandClot;
    public int RandColo;
    public int RandType;



    private void Start()
    {
        clothes[0] = "Ceket";
        clothes[1] = "hayalet";
        clothes[2] = "pantolon";
        colours[0] = "mavi";
        colours[1] = "pembe";
        colours[2] = "sari";
        colours[3] = "yesil";
        hasartype[0] = "düz";
        hasartype[1] = "hasarli";
        hasartype[2] = "stretch";
        hasartype[3] = "zigzag";
        chooseClothes();
    }
    private void Update()
    {
        didComplete = machine.GetComponent<machineCT>().isCompleted;
        if (didComplete)
        {
            foreach (var item in GetComponent<customer>().clothesP)
            {
                item.SetActive(false);
            }
        }
    }
    public void chooseClothes()
    {
        RandClot = 0;
        RandColo = Random.Range(0, 3);
        if (RandClot == 0)
        {
            if (RandColo == 0)
            {
                    clothesP[0].SetActive(true);
            }
            else if (RandColo == 1)
            {
                    clothesP[4].SetActive(true);
            }
            else if (RandColo == 2)
            {
                    clothesP[8].SetActive(true);
            }
            else if (RandColo == 3)
            {
                    clothesP[12].SetActive(true);
            }
        }

    }

}
