using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Quaternion spawnRotation = Quaternion.Euler(90, 0, 0);
    private Vector3 positionObject;
    public GameObject playerBullets;
    public int movementSpeed = 10;
    public float forwardInput;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        positionObject = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            positionObject = transform.position;
            Instantiate(playerBullets, positionObject, spawnRotation);
            BulletManager.bulletCounter += 1;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed * forwardInput);

        transform.Translate(Vector3.right * Time.deltaTime * movementSpeed * horizontalInput);

    }
}
