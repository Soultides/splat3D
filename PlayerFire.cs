using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerFire : MonoBehaviour
{
    public ParticleSystem discLaunch;
    //private GameObject player;

    public float fireRate;
    float timer = 0.01f;

    //float damage = 1f;

    public AudioSource audioSource;
    public AudioClip You_Firing_Splat;
    public GameObject prefabProjectile;


    void Start()
    {
        discLaunch.GetComponent<ParticleSystem>();

        audioSource = GetComponent<AudioSource>();

        //player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            prefabProjectile.SetActive(true);

            //Shoots and plays a sound on the firerate timer
            if (Input.GetButtonDown("Mouse Fire"))
            {
                discLaunch.Play();
                audioSource.PlayOneShot(You_Firing_Splat);
                timer = fireRate;
                prefabProjectile.SetActive(false);
                //player.GetComponent<PlayerHealth>().TakeDamage(damage);
            }

            if (Input.GetAxis("Controller Fire") == 1)
            {
                discLaunch.Play();
                audioSource.PlayOneShot(You_Firing_Splat);
                timer = fireRate;
                prefabProjectile.SetActive(false);
                //player.GetComponent<PlayerHealth>().TakeDamage(damage);
            }
        }
       
    }
}
