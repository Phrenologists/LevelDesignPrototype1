using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol1 : MonoBehaviour
{

    public Transform attackPoint;

    public GameObject projectilePrefab;

   
    
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(projectilePrefab, attackPoint.transform.position, attackPoint.transform.rotation);
    }
}
