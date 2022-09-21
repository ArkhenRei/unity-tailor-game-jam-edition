using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machineCT : MonoBehaviour
{
    public GameObject start;
    public GameObject button;
    public Renderer rend;
    public Color colorTurnTo = Color.white;
    public bool canStart;
    public bool isCompleted = false;
    // Start is called before the first frame update
    public void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    public void Update()
    {
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
        if (collision.gameObject.tag == "material")
        {
            rend.material.color = colorTurnTo;
            button.SetActive(true);
            
        }
    }
}
