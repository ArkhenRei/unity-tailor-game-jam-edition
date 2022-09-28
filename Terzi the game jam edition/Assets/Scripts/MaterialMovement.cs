using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialMovement : MonoBehaviour
{
    public bool _dragging;
    public Vector3 defaultPosition;

    private void Awake()
    {

        defaultPosition = transform.position;
    }
    void Update()
    {
        if (_dragging )
        {
            
            if (!screenCT.didFabric)
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

    public void OnTriggerStay(Collider other)
    {
        if (_dragging)
        {
            screenCT.didFabric = true;
        }
    }








}
