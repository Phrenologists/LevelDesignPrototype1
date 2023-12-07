using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GunManager1 : MonoBehaviour
{

    public GunScript1 gun1;

    public Shotgun1 gun2;
    public GranadeLauncher1 gun3;

    public GameObject Gun;



    bool hasGun1 = false;
    bool hasGun2 = false;
    bool hasGun3 = false;


    bool gun1Active = false;
    bool gun2Active = false;

    bool gun3Active = false;

    public Text firstMessage;

    public Text gun1Message;

    public Text gun2Message;

    public Text gun3Message;

    // Update is called once per frame
    void Update()
    {
        if(hasGun1 == true && Input.GetKeyDown(KeyCode.Alpha1))
        {
            gun1Active = true;
            gun2Active = false;
            gun3Active = false;
            Gun.GetComponent<Renderer>().material.color = Color.yellow;
        }

        if(hasGun2 == true && Input.GetKeyDown(KeyCode.Alpha2))
        {
            gun1Active = false;
            gun2Active = true;
            gun3Active = false;
            Gun.GetComponent<Renderer>().material.color = Color.blue;
        }

        if(hasGun3 == true && Input.GetKeyDown(KeyCode.Alpha3))
        {
            gun1Active = false;
            gun2Active = false;
            gun3Active = true;
            Gun.GetComponent<Renderer>().material.color = Color.green;
        }


        if(gun1Active == true)
        {
            gun1.enabled = true;
        }
        else
        {
            gun1.enabled = false;
        }

         if(gun2Active == true)
        {
            gun2.enabled = true;
        }
        else
        {
            gun2.enabled = false;
        }

         if(gun3Active == true)
        {
            gun3.enabled = true;
        }
        else
        {
            gun3.enabled = false;
        }
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("gun1Pickup"))
        {
            hasGun1 = true;
            gun1Active = true;
            gun2Active = false;
            gun3Active = false;
            Destroy(other.gameObject);
            Gun.GetComponent<Renderer>().material.color = Color.yellow;
            firstMessage.enabled = false;
            gun1Message.enabled = true;
            
        }
        if(other.gameObject.CompareTag("gun2Pickup"))
        {
            hasGun2 = true;
            gun2Active = true;
            gun1Active = false;
            gun3Active = false;
            Destroy(other.gameObject);
            Gun.GetComponent<Renderer>().material.color = Color.blue;
            firstMessage.enabled = false;
            gun2Message.enabled = true;
            
        }
        if(other.gameObject.CompareTag("gun3Pickup"))
        {
            hasGun3 = true;
            gun3Active = true;
            gun2Active = false;
            gun1Active = false;
            Destroy(other.gameObject);
            Gun.GetComponent<Renderer>().material.color = Color.green;
            firstMessage.enabled = false;
            gun3Message.enabled = true;
            
        }
    }
}
