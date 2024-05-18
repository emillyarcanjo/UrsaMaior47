using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
  
public class PlanetMovement : MonoBehaviour  
{  
    public GameObject OrbitCenter;
    public float a = 20;
    public float b = 12;
    public float TranslationPace = 0.005f;
    public float RotationPace = 0.2f;
    private float alpha;
    void Start()  
    {  
        alpha = 0f;
        transform.position = OrbitCenter.transform.position + new Vector3(a, 0f, 0f);
    }  
  
    void Update()  
    {  
        alpha += TranslationPace;
        float X = OrbitCenter.transform.position.x + (a * Mathf.Cos(alpha));
        float Y= OrbitCenter.transform.position.y + (b * Mathf.Sin(alpha));
        transform.position = OrbitCenter.transform.localRotation*(new Vector3(X,0,Y));
        transform.Rotate(new Vector3(0f, RotationPace, 0f));
    }

}  