using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generater : MonoBehaviour
{
    public GameObject[] Hands;
    public int x;
    GameObject hand;
    void Start()
    {
        StartCoroutine(Instantiat());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int RandomNumberGenerater()
    {
        x = Random.Range(0, Hands.Length - 1);
        return x;
    }
    IEnumerator Instantiat()
    {
        do
        {
            yield return new WaitForSeconds(3);

            hand = Instantiate(Hands[RandomNumberGenerater()], transform.position, Quaternion.identity);
        }
        while (true);
    }
}
