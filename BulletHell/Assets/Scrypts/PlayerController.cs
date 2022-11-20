using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    private Quaternion spawnRotation = Quaternion.Euler(90, 0, 0);
    private Vector3 positionObject;
    public GameObject playerBullets;
    public int movementSpeed = 10;
    private int speedAux;
    public float forwardInput;
    public float horizontalInput;

    public TimeManager timeManager;


    // Start is called before the first frame update
    void Start()
    {
        positionObject = transform.position;
        speedAux = movementSpeed;
        
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

        if (Input.GetKey(KeyCode.LeftShift)) {
            timeManager.DoSlowMotion();
            if (movementSpeed < 200) {
                movementSpeed += 5;
            } else {
                movementSpeed = 200;
            }
            BossControl.timeToShoot = 0.3f;
            PlayerBullets.speed = 150;
        } else {
            PlayerBullets.speed = 10;
            Time.timeScale += (1f / timeManager.slowDownLength) * Time.unscaledDeltaTime;
            Time.timeScale = Math.Clamp(Time.timeScale, 0f, 1f);
            if (movementSpeed > speedAux) {
                movementSpeed -= 20;
            } else {
                movementSpeed = speedAux;
            }
            BossControl.timeToShoot = 3f;
            
        }

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed * forwardInput);

        transform.Translate(Vector3.right * Time.deltaTime * movementSpeed * horizontalInput);

    }
}
