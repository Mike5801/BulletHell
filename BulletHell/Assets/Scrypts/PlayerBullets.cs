using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullets : MonoBehaviour
{
    public int speed = 10;
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
        transform.Translate( Vector3.up * speed * Time.deltaTime);

        if (hasInstantiated == true) {
            OnBecameInvisible();
        }
    }
}
