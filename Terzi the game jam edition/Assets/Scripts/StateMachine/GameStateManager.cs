using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public GameObject NextDayUI;
    public GameBaseState currentState;
    public PlayState playingState = new PlayState();
    public IronState ironingState = new IronState();
    public CustomerState customeringState = new CustomerState();

    void Start()
    {
        currentState = customeringState;

        currentState.EnterState(this);
    }


    void Update()
    {
        currentState.UpdateState(this);
    }
    public void SwitchState(GameBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
    public void NextDay()
    {

        NextDayUI.SetActive(true);
        screenCT.isNextDay = false;
    }

}
