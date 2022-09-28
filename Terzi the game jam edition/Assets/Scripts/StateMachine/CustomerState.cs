using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerState : GameBaseState
{
    public static int currentCloth;
    public static Color currentColor;
    public static int colorRandom;
    public override void EnterState(GameStateManager game)
    {
        currentCloth = Random.Range(0, 7);
        colorRandom = Random.Range(0,4);
        Debug.Log(currentCloth.ToString() + " " + colorRandom.ToString());
        switch (colorRandom)
        {
            case 0:
                currentColor = Color.blue;
                break;
            case 1:
                currentColor = Color.grey;
                break;
            case 2:
                currentColor = Color.red;
                break;
            case 3:
                currentColor = Color.green;
                break;


        }
        switch (currentCloth)
        {
            case 0:
                GameObject.FindGameObjectWithTag("CeketHasarli").transform.position=new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("CeketHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 1:
                GameObject.FindGameObjectWithTag("KazakHasarli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("KazakHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 2:
                GameObject.FindGameObjectWithTag("PantolonHasarli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("PantolonHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 3:
                GameObject.FindGameObjectWithTag("HoodyHasarli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("HoodyHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 4:
                GameObject.FindGameObjectWithTag("TshirtHasarli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("TshirtHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
            case 5:
                GameObject.FindGameObjectWithTag("CostumeHasarli").transform.position = new Vector3(0.1405f, -1.225128f, 0);
                GameObject.FindGameObjectWithTag("CostumeHasarli").GetComponent<SpriteRenderer>().color = currentColor;
                break;
        }

    }

    public override void OnCollisionEnter(GameStateManager game)
    {
        
    }

    public override void UpdateState(GameStateManager game)
    {
        if (screenCT.didTalk)
        {
            game.SwitchState(game.ironingState);
        }
    }
}
