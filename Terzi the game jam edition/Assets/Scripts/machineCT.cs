using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machineCT : MonoBehaviour
{
    public static SpriteRenderer rend;
    public Sprite highlight;
    public static Sprite normal;



    // Start is called before the first frame update
    public void Awake()
    {
        normal = rend.sprite;
        rend = GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        if (screenCT.didFabric == true)
        {
            rend.sprite = highlight;
        }
  
    }
   
}
