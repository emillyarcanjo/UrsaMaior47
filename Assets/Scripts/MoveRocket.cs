using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class MoveRocket : MonoBehaviour  
{  
     
    // Start is called before the first frame update  
    void Start()  
    {  
          
    }  
  
    // Update is called once per frame  
    void Update()  
    {  
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))  
        {
            transform.Translate(Vector3.down * 0.1f, Space.Self);    
        }  
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))  
        {  
            transform.Translate(Vector3.up * 0.1f, Space.Self);  
        }  
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))  
        {  
            transform.Translate(Vector3.back*0.1f, Space.Self);  
        }  
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))  
        {  
            transform.Translate(Vector3.forward*0.1f, Space.Self);    
        }  
    }  
}  