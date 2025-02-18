using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ultimate : MonoBehaviour
{
    public bool ultReady;
    public float ultTime;
    
    public GameObject bolt;
    Slider timer;

    void Start()
    {
        slider = GetComponent<Slider>();
    }

    
    void Update()
    {
        timer();
    }

   void timer()
    {
        if(ultTime < 1)
        {
            ultReady = false;
            ultTime += Time.deltaTime;
        }

        if(ultTime >= 1)
        {
            ultReady = true;
        }
    }

    public void boltSpawn()
    {
        if(ultReady == true)
        {
            Vector2 pos = transform.position;
            Instantiate(bolt, pos, Quaternion.identity);
            ultTime = 0;
        }
    }
}
