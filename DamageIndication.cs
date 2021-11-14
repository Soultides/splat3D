using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageIndication : MonoBehaviour
{
    Vector3 Pointing;

    public Transform target;

    public bool collision;

    void Start()
    {
        
    }

    void Update()
    {
        /*
        target = GameObject.FindWithTag("Enemy").GetComponent<EnemyBullet>().parentPos;
        Aim(target);
        */
    }

    public void Aim(Transform target)
    {
        /*
        Vector3 dir = target.position - Camera.main.WorldToScreenPoint(transform.position);

        Pointing.z = Mathf.Atan2(transform.position.y - dir.y, transform.position.x -dir.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(Pointing.z, Vector3.forward);
        */
    }
}
