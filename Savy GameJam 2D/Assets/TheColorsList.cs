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
        StartGame();
    }

    public void green()
    {
        nailpolishColor.color = new Color(0.4065498f, 0.7830189f, 0.3870772f, 1f);
        StartGame();
    }
    public void blue()
    {
        nailpolishColor.color = new Color(0.3212531f, 0.8526323f, 0.8867924f, 1f);
        StartGame();
    }

    public void pink()
    {
        nailpolishColor.color = new Color(0.9433962f, 0.2883588f, 0.6524814f, 1f);
        StartGame();
    }

    private void StartGame()
    {
        Destroy(colorCanvas);
        Time.timeScale = 1;
    }

}
