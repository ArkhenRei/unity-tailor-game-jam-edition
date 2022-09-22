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
            MoneyCT.GetComponent<MoneyCT>().score = Random.Range(0, 3);
            Debug.Log(MoneyCT.GetComponent<MoneyCT>().score.ToString());
            if (!iron.GetComponent<IronCt>().canIron)
            {
                if (MoneyCT.GetComponent<MoneyCT>().score == 2)
                {
                    MoneyCT.GetComponent<MoneyCT>().earned += 15;
                }
                else if (MoneyCT.GetComponent<MoneyCT>().score == 1)
                {
                    MoneyCT.GetComponent<MoneyCT>().earned += 5;
                }
                else if (MoneyCT.GetComponent<MoneyCT>().score == 0)
                {
                    MoneyCT.GetComponent<MoneyCT>().earned += -5;
                }
            }
            else if (iron.GetComponent<IronCt>().canIron)
            {
                if (MoneyCT.GetComponent<MoneyCT>().score == 2)
                {
                    MoneyCT.GetComponent<MoneyCT>().earned += 5;
                }
                else if (MoneyCT.GetComponent<MoneyCT>().score == 1 || MoneyCT.GetComponent<MoneyCT>().score == 0)
                {
                    MoneyCT.GetComponent<MoneyCT>().earned -= 5;
                }
            }
            start.SetActive(false);
            button.SetActive(false);
            isCompleted = true;
        }
    }
    public void startmachine()
    {

        start.SetActive(true);
        button.SetActive(false);
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
}
