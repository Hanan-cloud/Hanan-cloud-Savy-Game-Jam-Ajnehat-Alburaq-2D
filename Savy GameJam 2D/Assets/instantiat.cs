using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiat : MonoBehaviour
{
    public GameObject movingHands;
    public GameObject[] hands;
    public int x;


    private void Start()
    {
        StartCoroutine(generat());
    }



    public int RandomNumberGenerater()
    {
        x = Random.Range(0, hands.Length - 1);
        return x;

    }
    IEnumerator generat()
    {
       
        do
        {
            yield return new WaitForSeconds(3);
            movingHands = Instantiate ( hands[RandomNumberGenerater()],transform.position,Quaternion.identity);
        } while (true);
    }

}
