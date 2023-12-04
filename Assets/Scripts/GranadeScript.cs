using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GranadeScript : MonoBehaviour
{
    public Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Invoke("StopBullet", 0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        

        
        
        if(Input.GetMouseButton(1))
        {
            rb.constraints = RigidbodyConstraints.None;
        }
    }

    void StopBullet()
    {
        rb.constraints = RigidbodyConstraints.FreezeAll;
        
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }    
}
