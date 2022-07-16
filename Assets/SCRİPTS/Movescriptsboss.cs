using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movescriptsboss : MonoBehaviour
{
     public float speed=3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*Time.deltaTime*speed);
    }
}
