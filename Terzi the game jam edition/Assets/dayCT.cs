using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dayCT : MonoBehaviour
{
    public int day = 1;
    public float timeDay;
    public float timeKeep;
    public float endDay = 120f;
    public TextMeshProUGUI dayKeep;
    public GameObject NextDay;
    // Start is called before the first frame update
    void Start()
    {
        timeDay = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        dayKeep.text = "Day" + " " + day.ToString();
        timeKeep = Time.time - timeDay;
        if (timeKeep >= endDay)
        {
            if (NextDay.activeSelf== false)
            {
                NextDay.SetActive(true);
            }
            
            
        }
        
    }

    public void nextDayy()
    {
        day++;
        timeDay = Time.time;
        NextDay.SetActive(false);
    }
}
