using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPrefab;
    private Vector3 positionObject;
    private Quaternion spawnRotation = Quaternion.Euler(90, 0, 0);
    
    public int speed = 10;

    void Start()
    {
        positionObject = GameObject.Find("BossBullets").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(myPrefab, positionObject, spawnRotation);
    }
}
