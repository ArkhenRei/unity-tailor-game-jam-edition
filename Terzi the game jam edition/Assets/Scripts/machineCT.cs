using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machineCT : MonoBehaviour
{
    public GameObject start;
    public GameObject button;
    public GameObject MoneyCT;
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
        if (collision.gameObject.tag == "fabric")
        {
            MoneyCT.GetComponent<MoneyCT>().usedFabric++;
            gameObject.GetComponent<SpriteRenderer>().sprite = highlight;
            canPlay = true;
            button.SetActive(true);
            
        }
    }
}
