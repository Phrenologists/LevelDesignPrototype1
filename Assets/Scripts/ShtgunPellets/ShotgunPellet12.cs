using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunPellet12 : MonoBehaviour
{
    public float speed = 20.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward + new Vector3(0.2f, 0, 0) * Time.deltaTime * speed);
        Invoke("DestroyBullet", 0.1f);
    }
 void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
