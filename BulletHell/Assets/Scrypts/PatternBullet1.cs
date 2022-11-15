using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternBullet1 : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( Vector3.down * speed * Time.deltaTime);
    }
}
