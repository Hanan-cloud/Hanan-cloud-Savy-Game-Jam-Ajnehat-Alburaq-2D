using UnityEngine;
using TMPro;

public class PrintHscore : MonoBehaviour
{
    private TextMeshProUGUI HScore;
    void Start()
    {
        HScore = GetComponent<TextMeshProUGUI>();
        HScore.text = PlayerPrefs.GetInt("points").ToString();
    }
}


  
