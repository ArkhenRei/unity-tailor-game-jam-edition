using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialMovement : MonoBehaviour
{
    public bool _dragging;
    public Vector3 defaultPosition;
    public Color colorTurnTo = Color.white;
    public GameObject money;
    public int type;
    public bool didRope;
    public bool didFabric;

    private void Awake()
    {

        defaultPosition = transform.position;
    }
    void Update()
    {
        if (gameObject.CompareTag("rope"))
        {
            type = 0;
        }
        else if (gameObject.CompareTag("fabric"))
        {
            type = 1;
        }
        didRope = money.GetComponent<MoneyCT>().DidRope;
        didFabric = money.GetComponent<MoneyCT>().DidFabric;
        
        if (_dragging )
        {
            
            if (type==0 && didRope == false)
            {
                var mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = mousePosition;
            }
            else if (type == 1 && didFabric == false)
            {
                var mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = mousePosition;
            }
                  

        }

    }
    // Start is called before the first frame update
    private void OnMouseDown()
    {   
        _dragging = true;
    }
    private void OnMouseUp()
    {
        _dragging = false;
        transform.position = defaultPosition;
    }

   
    
    

    
        
    

}
