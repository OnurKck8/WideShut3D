using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockWave : MonoBehaviour
{
    public GameObject clockwave;
    public float Timer = 5f;
    public Transform CLOCK;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;

        if (Timer <= 0)
        {

            GameObject clone = Instantiate(clockwave, CLOCK.position, CLOCK.rotation);
            Timer = 0.6f;
            Destroy(clone, 2f);
        }
    }
}
