using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GranadeScript : MonoBehaviour
{
    public Rigidbody rb;

    

    public GameObject trampoline;

    public Transform spawnPoint;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Invoke("StopBullet", 0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        

        
        
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            rb.constraints = RigidbodyConstraints.None;
            var copy = Instantiate(trampoline, spawnPoint.position, spawnPoint.rotation);
            Destroy(copy, 1f);
            Invoke("DestroyBullet", 1.1f);
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
