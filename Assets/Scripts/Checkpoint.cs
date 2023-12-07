using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GamManager gm;
    public Transform player;
    public Renderer checkPointMaterial;
    void Awake()
    {
        checkPointMaterial = GetComponent<Renderer>();
        checkPointMaterial.material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            checkPointMaterial.material.color = Color.green;
            player = other.gameObject.GetComponent<Transform>();
            gm.respawnPoint = player.transform.position;
            gm.checkpoint = gameObject;
        }
    }
}
