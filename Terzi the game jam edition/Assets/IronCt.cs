using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronCt : MonoBehaviour
{
    public bool _dragging;
    public Vector3 defaultPosition;
    public Vector3 rotationIron;
    public ParticleSystem steam;
    public Vector2 velocityIron;
    public GameObject tamirli;
    public GameObject hasarli;
    public GameObject gameCT;
    public int cust;
    public int samecust =1;
    public bool canIron= false;

    private void Awake()
    {
        canIron = true;
        velocityIron = new Vector2(0, 0);
        rotationIron = new Vector3(15f, 0f, 45f);
        defaultPosition = transform.position;
    }
    void Update()
    {
        
       
        if (!_dragging)
        {
            transform.position = Vector3.Lerp(transform.position, defaultPosition, 3f * Time.deltaTime);
        }
        if (_dragging)
        {
            var mousePosition = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePosition;

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
            if (canIron == true)
            {
                Invoke("playSteam", 1f);
                hasarli = collision.gameObject;
            }
          
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
        hasarli.SetActive(false);
        tamirli.gameObject.SetActive(true);
        canIron=false;
        if (samecust>5)
        {
            samecust = 1;
        }
    }
  
}
