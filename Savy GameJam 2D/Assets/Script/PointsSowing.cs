using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsSowing : MonoBehaviour
{

    public TextMeshProUGUI Score;
    void Start()
    {
        Score = GetComponent<TextMeshProUGUI>();
        Score.text = GameManager.GetPoints().ToString();

    }

 
}
