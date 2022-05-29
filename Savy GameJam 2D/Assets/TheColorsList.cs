using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheColorsList : MonoBehaviour
{
    // public Color32 LightBlue= new Color32(92, 232, 241, 255);
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
        nailpolishColor.color = Color.red;
        
    }

    public void pink()
    {
        nailpolishColor.color = new Color(0.6509434f, 0.3960929f, 0.5295146f, 1f);
        
    }
    public void green()
    {
        nailpolishColor.color = new Color(0.3019313f, 0.5566038f, 0.3892476f, 1f);

    }
    public void skyBlue()
    {
        nailpolishColor.color = new Color(0.0473478f, 0.5182636f, 0.5283019f, 1f);
        
    }

    public void black()
    {
        nailpolishColor.color = new Color(0f, 0f, 0f, 1f);
        
    }
    public void Purbol()
    {
        nailpolishColor.color = new Color(0.4445616f, 0.2382075f, 0.5f, 1f);
        
    }

    private void StartGame()
    {
        Destroy(colorCanvas);
        Time.timeScale = 1;
    }

}
