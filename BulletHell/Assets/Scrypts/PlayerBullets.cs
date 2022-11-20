using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullets : MonoBehaviour
{
    public static int speed = 10;

    void OnBecameInvisible() {
        Destroy(gameObject);
        BulletManager.bulletCounter -= 1;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Boss"){
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( Vector3.up * speed * Time.deltaTime);
    }
}
