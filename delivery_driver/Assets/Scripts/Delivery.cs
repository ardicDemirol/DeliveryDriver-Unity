using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 1.0f;
    bool hasPackage = false;

    private void Start()
    {
        Debug.Log(hasPackage);  
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("carpýsma gerçekleþti");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(other.gameObject,destroyDelay);
        }
        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Packed Delivered");
            hasPackage=false;   
        }
    }
}
