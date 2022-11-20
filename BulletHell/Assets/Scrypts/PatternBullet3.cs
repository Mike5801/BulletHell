using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternBullet3 : MonoBehaviour
{
    public int speed = 20;

    void OnBecameInvisible() {
        Destroy(gameObject);
        BulletManager.bulletCounter -= 1;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( Vector3.down * speed * Time.deltaTime);
    }
}
