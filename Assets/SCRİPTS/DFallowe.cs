using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DFallowe : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset=new Vector3(0,2,-2);
    void Start()
    {
        
    }

    void LateUpdate()
    { //Kamera takip kodu araca sabitle ve istedğin pozisyona kamerayı çekme
        transform.position=player.transform.position;
    }
    void Update()
    {
        
    }
}
