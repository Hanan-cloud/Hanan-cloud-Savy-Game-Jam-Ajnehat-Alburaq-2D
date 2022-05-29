using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MaleFingerCollide : MonoBehaviour
{
<<<<<<< Updated upstream
    [SerializeField]
    public GameObject gameManager;
    public GameManager gamemanager;

    

    void Start()
    {
        gameManager = GameObject.Find("GameObjectManager");
         gamemanager = gameManager.GetComponent<GameManager>();
=======
    public GameObject gameManager;
    public GameManager gamemanager;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager");
        gamemanager = gameManager.GetComponent<GameManager>();
>>>>>>> Stashed changes

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player")){
            //do: OR END GAME by GameManager.EndGame();
<<<<<<< Updated upstream
          
            gamemanager.EndGame();
          
=======
            gamemanager.EndGame();
            Debug.Log("player collided with MaleFinger, points= "+GameManager.GetPoints());
>>>>>>> Stashed changes
            
        }
    }
}
