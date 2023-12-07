using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GranadeScript1 : MonoBehaviour
{
    public Rigidbody rb;

    private bool primed = false;

    public GameObject trampoline;

    public Transform spawnPoint;

    public GranadeLauncher1 whenToShoot;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Invoke("StopBullet", 0.4f);

        whenToShoot = GameObject.FindGameObjectWithTag("Gun").GetComponent<GranadeLauncher1>();
    }

    // Update is called once per frame
    void Update()
    {
        

        
        
        if(Input.GetKey(KeyCode.Mouse1) && primed)
        {
            rb.constraints = RigidbodyConstraints.None;
            var copy = Instantiate(trampoline, spawnPoint.position, Quaternion.LookRotation(Vector3.forward));//spawnPoint.rotation);
            Destroy(copy, 3f);
            Invoke("DestroyBullet", 0.00f);
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
