using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myPrefab;
    private Vector3 positionObject;
    private Quaternion spawnRotation = Quaternion.Euler(90, 0, 0);
    public int ticksPerBullet = 20;
    private int count = 0;
    public int speed = 10;


    void Start()
    {
        positionObject = GameObject.Find("Flying Insect").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        positionObject = GameObject.Find("Flying Insect").transform.position;
        
        if (count < ticksPerBullet) {
            count++;
        } else {
            Instantiate(myPrefab, positionObject, spawnRotation);
            count = 0;
        }        
    }
}
