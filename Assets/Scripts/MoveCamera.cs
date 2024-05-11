using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class MoveCamera : MonoBehaviour  
{  
    public GameObject Rocket;
    private Vector3 offset;
    public float smoothTime = 0.2f;
    private Vector3 velocity = Vector3.zero;
    void Start()  
    {  
        offset = transform.position - Rocket.transform.position;
    }  
  
    void Update()  
    {  
        if (Input.GetKey(KeyCode.A))  
        {  
            transform.RotateAround(Rocket.transform.position, Rocket.transform.up, -0.5f);    
        }
        if (Input.GetKey(KeyCode.D))  
        {  
            transform.RotateAround(Rocket.transform.position, Rocket.transform.up, 0.5f);   
        }
        if (Input.GetKey(KeyCode.W))  
        {  
            transform.RotateAround(Rocket.transform.position, Rocket.transform.forward, 0.5f);    
        }
        if (Input.GetKey(KeyCode.S))  
        {  
            transform.RotateAround(Rocket.transform.position, Rocket.transform.forward, -0.5f);    
        }
    }

    void LateUpdate(){
        Vector3 targetPosition = Rocket.transform.position + Rocket.transform.localRotation*offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}  