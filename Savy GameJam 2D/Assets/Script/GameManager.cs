using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
<<<<<<< Updated upstream
    public GameObject updats;
    public GameObject losingPanal;
    public static int points;
    [SerializeField] private static GameObject soundObj;
    private static effect ef;
=======
    
    public static int points;
   
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        ef = GetComponent<effect>();
    }

    // Update is called once per frame
<<<<<<< Updated upstream
  
    public static void IncreasePoints(){
        points=points+1;
        if(PlayerPrefs.GetInt("points")< points)
        {
            PlayerPrefs.SetInt("points",points);
=======
    void Update()
    {
        if(points <0){
           
        }
    }
    public static void IncreasePoints(){
        points=points+1;
         if(points>=3){
            Debug.Log("player won!");
            
        }
        
    }
    public static void DecreasePoints(){
        points=points-1;
        if(points<0){
            Debug.Log("player lost!");
           
>>>>>>> Stashed changes
        }
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

<<<<<<< Updated upstream
    public void EndGame(){
        Time.timeScale = 0;
       ef.lose();
        PlayerPrefs.Save();

        StartCoroutine(Wait3Coroutine());
=======
    public  void EndGame(){
        StartCoroutine(Wait3Coroutine());

>>>>>>> Stashed changes
        //do: change behaviour after time is paused here...
    }
    public void EndFromFail()
    {
        Time.timeScale = 0;
        StartCoroutine(Wait3Coroutine());
    }

<<<<<<< Updated upstream
   public IEnumerator Wait3Coroutine()
    {
        //Debug.Log("reloading scene in 3 seconds");
        yield return new WaitForSecondsRealtime(2);
        losingPanal.SetActive(true);
        updats.SetActive(false);

=======
   public  IEnumerator Wait3Coroutine()
    {
      
        yield return new WaitForSecondsRealtime(3);
        
>>>>>>> Stashed changes

    }
}
