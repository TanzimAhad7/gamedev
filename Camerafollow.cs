using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
   
    public Transform player;
    public float followSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,player.position,Time.deltaTime*followSpeed);
    }
}
