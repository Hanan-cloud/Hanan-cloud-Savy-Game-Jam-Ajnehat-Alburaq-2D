using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointUpdate : MonoBehaviour
{
    public TextMeshProUGUI Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Score.text = GameManager.GetPoints().ToString();
    }
}
