using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi : MonoBehaviour
{
     public float mermihasar,kayıp;
     public Transform mermi;
     Transform muzzle;
    void Start()
    {
        muzzle=transform.GetChild(3);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            atis();
        }
    }
    void atis(){
        Instantiate(mermi,muzzle.position,Quaternion.identity);
    }
}
