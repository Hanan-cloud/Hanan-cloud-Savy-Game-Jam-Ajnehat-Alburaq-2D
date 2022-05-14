using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointShow : MonoBehaviour
{
    public TextMeshProUGUI Score;
    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<TextMeshProUGUI>();
        Score.text = GameManager.GetPoints().ToString();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
