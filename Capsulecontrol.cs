using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsulecontrol : MonoBehaviour
{
   
    public float speed ;
   
    void Start()
    {
        speed = 10f;
    }

    
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*speed*Time.deltaTime,0,Input.GetAxis("Vertical")*speed * Time.deltaTime);
        
    }
}
