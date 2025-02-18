using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ultimate : MonoBehaviour
{
    public bool ultReady;
    public float ultTime;
    public float boltLifetime;
    
    public GameObject bolt;
    public GameObject boltSpawner;
    Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>(); //get slider
    }

    
    void Update()
    {
        timer();
    }

   void timer()
    {
        if(ultTime < 1)
        {
            ultReady = false; //ultimate cannot be used while charging
            ultTime += Time.deltaTime; //start timer

            slider.value = ultTime % slider.maxValue; //show ultimate charge visually with slider
        }

        if(ultTime >= 1)
        {
            ultReady = true; //ultimate can now be used
            ultTime = 1; //set time to 1 in case it goes over

            slider.value = 1; //hold max slider value
        }
    }

    public void boltSpawn()
    {
        if(ultReady == true)
        {
            Vector2 pos = boltSpawner.transform.position; //get spawner position
            GameObject boltDespawn = Instantiate(bolt, pos, Quaternion.identity); //spawn bolt prefab
            Destroy(boltDespawn, boltLifetime); //destroy bolt 
            ultTime = 0; //reset timer
        }
    }
}
