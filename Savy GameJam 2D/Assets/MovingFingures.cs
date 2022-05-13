using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFingures : MonoBehaviour
{
    public Transform fingureTransform;
   public float X, Y, Z;
    Vector3 pose;
    void Start()
    {
        fingureTransform = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        pose = new Vector3(X, Y, Z);
        fingureTransform.position += pose * Time.deltaTime;
        
    }
}
