using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletManager : MonoBehaviour
{
    public static int bulletCounter = 0;
    public TextMeshProUGUI bulletText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletText.text = bulletCounter.ToString();
    }
}
