using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameCT : MonoBehaviour
{

    public TextMeshProUGUI SpeechBubble;
    public GameObject panel;
    public string[] words = new string[10];
    public int sayac = 0;
    public GameObject machine;
    public GameObject speech;

    public void Start()
    {
        words[0] = "Can you repair my coats?";
        words[1] = "Thank you so much.";
        

    }
    // Start is called before the first frame update
    public void Update()
    {

        if (machine.GetComponent<machineCT>().isCompleted)
        {
            Invoke("text", 1f);
            machine.GetComponent<machineCT>().isCompleted = false;
            Invoke("close", 3f);


        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel.SetActive(true);
        }
    }
    public void resumeA()
    {
        panel.SetActive(false);
    }
    public void exitA()
    {
        Application.Quit();
    }


    public void text()
    {
        SpeechBubble.text = words[sayac];
        sayac++;
        

    }
    public void nextCustomer()
    {
        speech.SetActive(true);
        SpeechBubble.text = "Hi";
        Invoke("text", 2f);
        
    }
    public void close()
    {
        SpeechBubble.text = "";
        speech.SetActive(false);
    }
}
