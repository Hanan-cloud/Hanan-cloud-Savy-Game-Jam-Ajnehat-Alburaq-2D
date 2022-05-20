using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    [SerializeField]
    public GameObject gameManager;
    public GameManager gamemanager;



    void Start()
    {
        gameManager = GameObject.Find("GameObjectManager");
        gamemanager = gameManager.GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            //do: OR END GAME by GameManager.EndGame();

            gamemanager.EndFromFail();


        }
    }
}
