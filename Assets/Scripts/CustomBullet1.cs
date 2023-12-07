using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBullet1 : MonoBehaviour
{
   void Update()
    {
        
        Invoke("DestroyBullet", 1f);
    }

    void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
