using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MaleFingerCollide : MonoBehaviour
{
    [SerializeField]
    public GameObject gameManager;
    public GameManager gamemanager;

    void Start()
    {
        
        gamemanager = gameManager.GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player")){
            //do: OR END GAME by GameManager.EndGame();
            gamemanager.EndGame();
            Debug.Log("player collided with MaleFinger, points= "+GameManager.GetPoints());
            
        }
    }
}
