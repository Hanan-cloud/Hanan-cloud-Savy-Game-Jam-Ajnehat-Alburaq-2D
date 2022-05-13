using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorsList : MonoBehaviour
{
    public SpriteRenderer nailpolishColor;
    public GameObject nailpolish;
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    void Start()
    {
        DontDestroyOnLoad(nailpolish);
        nailpolishColor = nailpolish.GetComponent<SpriteRenderer>();
    }

   public void red()
    {
        nailpolishColor.color =Color.red;
       
    }
   
    public void green()
    {
        nailpolishColor.color = Color.green;
    }
    public void blue()
    {
        nailpolishColor.color = Color.blue;
    }
}
