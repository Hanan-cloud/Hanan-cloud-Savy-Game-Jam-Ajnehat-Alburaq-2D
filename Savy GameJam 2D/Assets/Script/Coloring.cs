using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coloring : MonoBehaviour
{
   
    public SpriteRenderer nailPolishColor;
    private SpriteRenderer nailColor;
    void Start()
    {
      
        nailPolishColor = GetComponent<SpriteRenderer>();
      
    
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hi");
        nailColor = collision.GetComponent<SpriteRenderer>();
        nailColor.color = nailPolishColor.color;

    }
}
