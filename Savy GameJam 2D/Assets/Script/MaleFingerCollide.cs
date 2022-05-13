using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaleFingerCollide : MonoBehaviour
{
    //GameManager GameManagerScript = new GameManager(); this is for non-static functions/attributes
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player")){
            //do: OR END GAME by GameManager.EndGame();
            GameManager.DecreasePoints();
            Debug.Log("player collided with MaleFinger, points= "+GameManager.GetPoints());
            
        }
    }
}
