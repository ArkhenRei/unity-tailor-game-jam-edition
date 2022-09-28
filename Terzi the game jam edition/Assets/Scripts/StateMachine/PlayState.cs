using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayState : GameBaseState
{
    public override void EnterState(GameStateManager game)
    {
        
    }

    public override void OnCollisionEnter(GameStateManager game)
    {
        
    }

    public override void UpdateState(GameStateManager game)
    {
        if (screenCT.didPlay)
        {
            screenCT.nextCustomer();
            game.SwitchState(game.currentState);
        }
    }
}
