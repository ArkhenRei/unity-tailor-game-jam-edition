using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject NextDayUI;
    public GameObject EndGameUI;
    public GameObject NeedleUI;
    public GameObject PauseMenuUI;


    public void NextDay()
    {

        NextDayUI.SetActive(true);
        screenCT.isNextDay = false;
    }







}