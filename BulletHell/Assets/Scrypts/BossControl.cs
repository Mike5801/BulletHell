using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BossControl : MonoBehaviour
{
    //Bullet 1 Settings
    public GameObject myPrefab;
    
    //Bullet 2 Settings
    public GameObject myPrefab2;

    //Bullet 3 Settings:
    public GameObject myPrefab3;

    private Vector3 positionObject;
    private Quaternion spawnRotation = Quaternion.Euler(90, 0, 0);
    public int ticksPerBullet = 20;
    private int count = 0;

    public static float timeToShoot = 0;

    public void OnEnable()
    {
        TimeManager.OnMinuteChanged += TimeCheck;
    }

    public void OnDisable()
    {
        TimeManager.OnMinuteChanged -= TimeCheck;
    }

    private void TimeCheck()
    {
        if(TimeManager.Minute == 1) 
        {
            StartCoroutine(MoveBoss());
        }
        if(TimeManager.Minute < 10)
        {
            StartCoroutine(FirePattern1());
        }
        if(TimeManager.Minute == 10) 
        {
            StartCoroutine(MoveBoss2());
        }
        if(TimeManager.Minute >= 10 && TimeManager.Minute < 20)
        {
            StartCoroutine(FirePattern2());
        }
        if(TimeManager.Minute == 19) 
        {
            StartCoroutine(MoveBoss3());
        }
        if(TimeManager.Minute >= 20 && TimeManager.Minute <= 30)
        {
            StartCoroutine(FirePattern3());
        }    
    }

    void Start()
    {
        positionObject = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        positionObject = transform.position;
    }

    private IEnumerator FirePattern1()
    {   
        Quaternion rotation = Quaternion.Euler(0, 0, 3);
        float timeElapsed = 0;
        timeToShoot = 3;
        Quaternion resultingQuaternion = spawnRotation;

        while(timeElapsed < timeToShoot){
            resultingQuaternion *= rotation;          
            if (count < ticksPerBullet) {
                count++;
            } else {
                Instantiate(myPrefab, positionObject, resultingQuaternion);
                BulletManager.bulletCounter += 1;
                count = 0;
            }     
            timeElapsed += Time.deltaTime;
            yield return null;
        }
    }

    private IEnumerator FirePattern2()
    {
        Quaternion rotation = Quaternion.Euler(0, 0, 15);
        Quaternion rotation2 = Quaternion.Euler(0, 0, -15);
        float timeElapsed = 0;
        timeToShoot = 3;
        Quaternion resultingQuaternion = spawnRotation;
        Quaternion resultingQuaternion2 = spawnRotation;

        while(timeElapsed < timeToShoot){  
            resultingQuaternion *= rotation;
            resultingQuaternion2 *= rotation2;
                   
            if (count < ticksPerBullet) {
                count++;
            } else {
                Instantiate(myPrefab2, positionObject, resultingQuaternion);
                Instantiate(myPrefab2, positionObject, resultingQuaternion2);
                BulletManager.bulletCounter += 2;
                count = 0;
            }     
            timeElapsed += Time.deltaTime;
            yield return null;
        }
    }

    private IEnumerator FirePattern3()
    {
        Quaternion rotation = Quaternion.Euler(0, 0, 3);
        Quaternion rotation2 = Quaternion.Euler(0, 0, 3);
        Quaternion rotation3 = Quaternion.Euler(0, 0, 30);
        Quaternion rotation4 = Quaternion.Euler(0, 0, 30);

        float timeElapsed = 0;
        timeToShoot = 3;

        Quaternion resultingQuaternion = spawnRotation;
        Quaternion resultingQuaternion2 = spawnRotation * Quaternion.Euler(0,180,0);
        Quaternion resultingQuaternion3 = spawnRotation;
        Quaternion resultingQuaternion4 = spawnRotation * Quaternion.Euler(0,180,0);


        while(timeElapsed < timeToShoot){    
            resultingQuaternion *= rotation;
            resultingQuaternion2 *= rotation2;
            resultingQuaternion3 *= rotation3;
            resultingQuaternion4 *= rotation4;

            if (count < ticksPerBullet) {
                count++;
            } else {
                Instantiate(myPrefab3, positionObject, resultingQuaternion);
                Instantiate(myPrefab3, positionObject, resultingQuaternion2);
                Instantiate(myPrefab3, positionObject, resultingQuaternion3);
                Instantiate(myPrefab3, positionObject, resultingQuaternion4);
                BulletManager.bulletCounter += 4;
                count = 0;
            }     
            timeElapsed += Time.deltaTime;
            yield return null;
        }
    }

    private IEnumerator MoveBoss()
    {
        //11.36, 1.16, -47.42
        Vector3 targetPos = new Vector3(5.36f, 1.16f, -47.42f); //-6, 0.48

        Vector3 currentPos = transform.position;

        float timeElapsed = 0;
        float timeToMove = 3;
        while(timeElapsed < timeToMove){
            transform.position = Vector3.Lerp(currentPos, targetPos, timeElapsed/timeToMove);
            timeElapsed += Time.deltaTime;
            yield return null;
        }                
    }

    private IEnumerator MoveBoss2() 
    {
        Vector3 targetPos = new Vector3(16.5f, 1.16f, -49.42f);
        Vector3 currentPos = transform.position;
        float timeElapsed = 0;
        float timeToMove = 3;
        while(timeElapsed < timeToMove){
            transform.position = Vector3.Lerp(currentPos, targetPos, timeElapsed/timeToMove);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
    }

    private IEnumerator MoveBoss3() 
    {
        Vector3 targetPos = new Vector3(11.36f, 1.16f, -45);
        Vector3 currentPos = transform.position;
        float timeElapsed = 0;
        float timeToMove = 3;
        while(timeElapsed < timeToMove){
            transform.position = Vector3.Lerp(currentPos, targetPos, timeElapsed/timeToMove);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
    }
}
