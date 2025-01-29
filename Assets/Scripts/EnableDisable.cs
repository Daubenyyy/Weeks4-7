using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public SpriteRenderer sr;
    public EnableDisable script;
    public GameObject go;
    public AudioSource audioSorce;
    public AudioClip clip;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //sr.enabled = false;
            //script.enabled = false;
            go.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //sr.enabled = true;
            //script.enabled = true;
            go.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (audioSorce.isPlaying == false)
            {
                //audioSorce.Play();
                audioSorce.PlayOneShot(clip);
            }
            
            
        }
    }
}
