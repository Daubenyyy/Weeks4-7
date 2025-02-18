using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour
{
    public float speed;

    Vector2 pos;

    void Start()
    {
        
    }

    
    void Update()
    {
        moveBolt();
    }

    void moveBolt()
    {
        pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
    }
}
