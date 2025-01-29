using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockHand : MonoBehaviour
{
    public float t;
    public float counter;
    public AudioSource cuckoo;

    void Start()
    {
        t = 0;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        rotation();
    }

    void rotation()
    {
        t -= 10f * Time.deltaTime;
        counter += 10f * Time.deltaTime;

        transform.rotation = Quaternion.Euler(0, 0, t);

        if(counter >= 30f)
        {
            cuckoo.Play();
            counter = 0f;
        }
    }
}
