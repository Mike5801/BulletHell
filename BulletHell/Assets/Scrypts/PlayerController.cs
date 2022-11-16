using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Quaternion spawnRotation = Quaternion.Euler(90, 0, 0);
    private Vector3 positionObject;
    public GameObject playerBullets;

    // Start is called before the first frame update
    void Start()
    {
        positionObject = GameObject.Find("StarSparrow1").transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            positionObject = GameObject.Find("StarSparrow1").transform.position;
            Instantiate(playerBullets, positionObject, spawnRotation);
        }  
    }
}
