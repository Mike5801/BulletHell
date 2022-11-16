using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternBullet1 : MonoBehaviour
{
    public int speed = 20;
    private bool hasInstantiated = false;

    void OnBecameInvisible() {
        Destroy(gameObject);
    }

    void OnBecameVisible() {
        hasInstantiated = false;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( Vector3.down * speed * Time.deltaTime);
        //OnBecameVisible();

        if (hasInstantiated == true) {
            OnBecameInvisible();
        }
    }
}
