using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    float damage = 5f;

    public GameObject SpawnPoint;
    void Start()
    {
        SpawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.gameObject.GetComponent<CharacterController>().enabled = false;
            //Debug.Log("Player Detected");
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
            //Debug.Log(other.gameObject.transform);
            other.gameObject.GetComponent<PlayerMovement>().velocity = new Vector3 (0f,-9.8f, 0f);
            other.gameObject.transform.position = SpawnPoint.transform.position;
            //Debug.Log("Player TP");
            other.gameObject.GetComponent<CharacterController>().enabled = true;
        }

    }
}
