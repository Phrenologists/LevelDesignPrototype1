using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GranadeScript : MonoBehaviour
{
    public Rigidbody rb;

    private bool primed = false;

    public GameObject trampoline;

    public Transform spawnPoint;

    public GranadeLauncher whenToShoot;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Invoke("StopBullet", 0.4f);

        whenToShoot = GameObject.FindGameObjectWithTag("Gun").GetComponent<GranadeLauncher>();
    }

    // Update is called once per frame
    void Update()
    {
        

        
        
        if(Input.GetKeyDown(KeyCode.Mouse1) && primed)
        {
            rb.constraints = RigidbodyConstraints.None;
            var copy = Instantiate(trampoline, spawnPoint.position, spawnPoint.rotation);
            Destroy(copy, 3f);
            Invoke("DestroyBullet", 1.1f);
        }
    }

    void StopBullet()
    {
        //rb.constraints = RigidbodyConstraints.FreezeAll;
        primed = true;
    }

       

    void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other) {

    if(other.gameObject.CompareTag("Ground"))
    {
        Destroy(gameObject);
        
        whenToShoot.canShoot = true;
    }

    }
}
