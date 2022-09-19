using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fabric_controller : MonoBehaviour
{
    [SerializeField] float speedVer = 1f;
    [SerializeField] float speedHor = 0.5f;
    [SerializeField] float delay = 1f;
    float locationDistruption;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("waitForRandomNumber");
        transform.Translate(Input.GetAxis("Horizontal") * speedHor + locationDistruption * speedHor, Time.deltaTime * speedVer, 0, Space.World);
    }
    IEnumerator waitForRandomNumber()
    {
        yield return new WaitForSeconds(delay);

        locationDistruption = Random.Range(-1, 1);
        
    }
}
