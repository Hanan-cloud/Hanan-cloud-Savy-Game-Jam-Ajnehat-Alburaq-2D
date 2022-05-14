using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private Touch tch;
    bool grounded;
    [SerializeField] float jumpPower;

    //public int jumpNum = 7;
    //private int jumpCount ;
    // Start is called before the first frame update
    void Start()
    {
       // jumpCount = jumpNum;
        rb = GetComponent<Rigidbody2D>();
        grounded=false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > 0)
        {
            tch = Input.GetTouch(0);

            if (tch.phase == TouchPhase.Began )
            {
              //  print("jump by touch");
                jump();
            }

        } else if (Input.GetKeyDown("space") )
        {
           // print("jump using space button");
            jump();
        }
    }
    void jump()
    {
          rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);

      //  rb.AddForce(transform.up * Time.time * jumpPower);
        //jumpCount--;
    }

    //void OnCollisionEnter2D(Collision2D col)
    //{
    //    if(col.gameObject.CompareTag("Nail"))
    //    {
    //        grounded=true;
    //        print("grounded");
    //       // jumpCount = jumpNum;
    //    }
    //}
    //void OnCollisionExit2D(Collision2D col)
    //{
    //    if(col.gameObject.CompareTag("Nail")){
    //        grounded=false;
    //        print("not grounded");
    //    }
    //}



}
