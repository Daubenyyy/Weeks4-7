using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockHand : MonoBehaviour
{
    public float t;
    public float counter;
    public float i = 10;

    public AudioSource cuckoo;
    public SpriteRenderer bird;

    void Start()
    {
        t = 0;
        counter = 0;
        i = 10;
    }

    // Update is called once per frame
    void Update()
    {
        rotation();
        showBird();
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
            i = 0;
        }
    }

    void showBird()
    {

        if(i < 5f)
        {
            i += 10f * Time.deltaTime;
            bird.enabled = true;
        } else 
        {
            bird.enabled = false;
        }
    }
}
