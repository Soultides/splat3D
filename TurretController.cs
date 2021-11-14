using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    public GameObject prefabEnemyProjectile;
    public Transform ShotSpawn;

    float origY;
    float height = 0.25f;

    public float fireRate = 5f;

    float timer = 0.01f;

    public AudioSource audioSource;
    public AudioClip Enemy_Firing_Splat;

    public Transform bulletHolder;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //bulletHolder = gameObject.transform.Find("BulletHolder");
        origY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, origY + (Mathf.Sin(Time.time) * height), transform.position.z);
    }

    private void OnTriggerStay(Collider collision)
    {
        timer -= Time.deltaTime;

        if (collision.gameObject.tag == "Player")
        {

            transform.LookAt(collision.transform);

            if (timer <= 0)
            {

                Fire();

                timer = fireRate;

            }  

        }

    }

    void Fire()
    {

        Instantiate(prefabEnemyProjectile, ShotSpawn.transform.position, ShotSpawn.rotation, bulletHolder);
        audioSource.PlayOneShot(Enemy_Firing_Splat);

    }
}
