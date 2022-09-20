using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronCt : MonoBehaviour
{
    public bool _dragging;
    public Vector3 defaultPosition;
    public Vector3 rotationIron;
    public ParticleSystem steam;
    public float neededTime = 1000000f;
    public float keepTime =0f;
    public Vector2 velocityIron;
    public GameObject clothes;
    public GameObject collisionG;

    private void Awake()
    {
        velocityIron = new Vector2(0, 0);
        rotationIron = new Vector3(15f, 0f, 45f);
        defaultPosition = transform.position;
    }
    void Update()
    {
        if (_dragging == false)
        {
            transform.position = Vector3.Lerp(transform.position, defaultPosition, 3f * Time.deltaTime);
        }
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
        
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
    private void OnMouseDrag()
    {
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, rotationIron, 5f* Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "cloth")
        {
            Invoke("playSteam",1f);
            collisionG = collision.gameObject;
            
            

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "cloth")
        {
            CancelInvoke();
        }
    }
    public void playSteam()
    {

        steam.Play();
        collisionG.SetActive(false);
        clothes.gameObject.SetActive(true);
    }
  
}
