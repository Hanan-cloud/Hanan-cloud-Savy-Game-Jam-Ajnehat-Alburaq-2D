using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorsList : MonoBehaviour
{
    public SpriteRenderer nailpolishColor;
    public GameObject nailpolish;
    [SerializeField] GameObject colorCanvas;
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
        StartGame();



    }
   
    public void green()
    {
        nailpolishColor.color = Color.green;
        StartGame();
    }
    public void blue()
    {
        nailpolishColor.color = Color.blue;
        StartGame();
    }


    private void StartGame()
    {
        Destroy(colorCanvas);
        Time.timeScale = 1;
    }

}
