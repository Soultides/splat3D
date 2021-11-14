using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public GameObject enemySubEmitter;

    private GameObject target;

    //public GameObject damageIndicator;

    public float speed = 3f;
    public float step = 10f;

    float damage = 1f;

    public Transform bulletHolder;

    //public Transform parentPos;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        Destroy(gameObject, 10);

        /*
        damageIndicator = FindObjectOfType<DamageIndication>().gameObject;
        */
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            /*
            parentPos = GetComponentInParent<Transform>();
            damageIndicator.gameObject.GetComponent<DamageIndication>().Aim(parentPos);
            */

            collision.gameObject.GetComponent <PlayerHealth>().TakeDamage(damage);
            //Debug.Log("Hit Player");
        }

        Instantiate(enemySubEmitter, transform.position, transform.rotation, bulletHolder);
        //Debug.Log("Enemy PS");
        Destroy(gameObject);
    }
}
