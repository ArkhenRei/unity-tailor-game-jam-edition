using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class needle_controller : MonoBehaviour
{
    Animator myAnimator;
    [SerializeField] float score = 0, badQua = 958, aveQua = 1916;
    GameObject myIron;
    GameObject myGameController;
    public bool incScore, decScore, rightNeedle, didIron;
    public string qua;
    // Start is called before the first frame update
    void Start()
    {
        myIron = GameObject.Find("Iron");
        myAnimator = GetComponent<Animator>();
        myGameController = GameObject.Find("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        if (!myIron.GetComponent<IronCt>().canIron)
        {
            didIron = true;
        }
        else
        {
            didIron = false;
        }
        if (myGameController.GetComponent<MoneyCT>().didMachine)
        {
            rightNeedle = true;
        }
        else
        {
            rightNeedle = false;
        }
        if (Input.GetButton("needlekey"))
        {
            myAnimator.GetComponent<Animator>().enabled = true;
            if(incScore)
            {
                score++;
            }
            else if(decScore)
            {
                score--;
            }
        }
        else
        {
            myAnimator.GetComponent<Animator>().enabled = false;
        }
       
        if (!didIron && !rightNeedle)
        {
            qua = "bad";
        }
        if (didIron || rightNeedle)
        {
            if (score <= badQua)
            {
                qua = "bad";
            }
            else
            {
                qua = "ave";
            }
        }
        if (didIron && rightNeedle)
        {
            if (score <= badQua)
            {
                qua = "bad";
            }
            else if (score > badQua && score <= aveQua)
            {
                qua = "ave";
            }
            else
            {
                qua = "good";
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        incScore = false;
        decScore = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        incScore = true;
        decScore = false;
    }
}
