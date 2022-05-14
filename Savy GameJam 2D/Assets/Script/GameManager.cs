using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject updats;
    public GameObject losingPanal;
    public static int points;
    [SerializeField] private static GameObject soundObj;
    private static effect ef;
    // Start is called before the first frame update
    void Start()
    {
        points=0;
        ef = GameObject.Find("Sfx").GetComponent<effect>();
    }

    // Update is called once per frame
  
    public static void IncreasePoints(){
        points=points+1;
      ef.win();

    }
    //public static void DecreasePoints(){
    //    points=points-1;
    //    if(points<0){
    //        Debug.Log("player lost!");
            
    //    }
    //}

    public static int GetPoints(){
        return points;
    }

    public void EndGame(){
        Time.timeScale = 0;
       ef.lose();
        StartCoroutine(Wait3Coroutine());
        //do: change behaviour after time is paused here...
    }

   public IEnumerator Wait3Coroutine()
    {
        //Debug.Log("reloading scene in 3 seconds");
        yield return new WaitForSecondsRealtime(2);
        losingPanal.SetActive(true);
        updats.SetActive(false);


    }
}
