using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAmmunition : MonoBehaviour
{
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Invoke("DestroyBullet", 1f);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
   private void OnCollisionEnter(Collision other) {
    if(other.gameObject.CompareTag("Player"))
    {
        Debug.Log("Wtf");
        Destroy(other.gameObject);
    }
   }
}
