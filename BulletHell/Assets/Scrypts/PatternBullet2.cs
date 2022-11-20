using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternBullet2 : MonoBehaviour
{
    public int speed = 20;
    private bool hasInstantiated = false;

    void OnBecameInvisible() {
        Destroy(gameObject);
        BulletManager.bulletCounter -= 1;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( Vector3.down * speed * Time.deltaTime);

        if (hasInstantiated == true) {
            OnBecameInvisible();
        }
    }
}
