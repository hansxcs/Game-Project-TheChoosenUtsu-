﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletHit : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemyBullet")
        {
            GameObject go = col.gameObject;
            go.GetComponent<PlayerBullet>().DestroyBullet();

            //EnemyHealth eh = gameObject.GetComponent<EnemyHealth>();

            //if (eh != null)
            //{
            //    eh.damageHealth(1);

            //    if (eh.isHealthLessThanZero())
            //        Destroy(gameObject);
            //}
        }
    }
}
