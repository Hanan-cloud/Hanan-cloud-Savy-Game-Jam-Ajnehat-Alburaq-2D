using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int points;
    // Start is called before the first frame update
    void Start()
    {
        points=0;
    }

    // Update is called once per frame
    void Update()
    {
        if(points <0){
            StartCoroutine(Wait3Coroutine());
        }
    }
    public static void IncreasePoints(){
        points=points+1;
         if(points>=3){
            Debug.Log("player won!");
            EndGame();
        }
        
    }
    public static void DecreasePoints(){
        points=points-1;
        if(points<0){
            Debug.Log("player lost!");
            EndGame();
        }
    }

    public static int GetPoints(){
        return points;
    }

    public static void EndGame(){
        Time.timeScale = 0;
        //do: change behaviour after time is paused here...
    }

    IEnumerator Wait3Coroutine()
    {
        Debug.Log("reloading scene in 3 seconds");
        yield return new WaitForSecondsRealtime(3);
        Application.LoadLevel("Game");

    }
}
