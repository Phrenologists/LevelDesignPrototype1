using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranadeLauncher : MonoBehaviour
{
  public Transform launchPoint;
  public GameObject projectile;
  public float launchSpeed = 12f;

  public bool canShoot = true;

  void Update()
  {
    if(Input.GetMouseButtonDown(0) )//&& canShoot == true)
    {
        var _oldProjectiles = GameObject.FindGameObjectsWithTag("Bullet");
        foreach (GameObject _bullet in _oldProjectiles)
            {
                Destroy(_bullet);
            }
        var _projectile = Instantiate(projectile, launchPoint.position, launchPoint.rotation);
        _projectile.GetComponent<Rigidbody>().velocity = (launchSpeed * launchPoint.up) + (launchSpeed*1.2f * launchPoint.forward);

        Debug.Log(_projectile.GetComponent<Rigidbody>().velocity);

        canShoot = false;
    }

    //if(Input.GetMouseButtonDown(1))
    //{
    //    canShoot = true;
    //}
  }
}
