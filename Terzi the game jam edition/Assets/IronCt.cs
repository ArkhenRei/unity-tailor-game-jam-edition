using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronCt : MonoBehaviour
{
    public bool _dragging;
    public Vector3 defaultPosition;

    private void Awake()
    {
        defaultPosition = transform.position;
    }
    void Update()
    {
        if (!_dragging) return;
        var mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePosition;
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
