using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private Touch tch;
    bool grounded;
    [SerializeField] float jumpPower;

    private int jumpCount = 2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        grounded=false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > 0)
        {
            tch = Input.GetTouch(2);

            if (tch.phase == TouchPhase.Began & jumpCount>0)
            {
                print("jump by touch");
                jump();
            }

        } /*else if (Input.GetKeyDown("space") )
        {
            print("jump using space button");
            jump();
        }*/
    } 
    void jump(){
        rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
        jumpCount--;
    }
   /* void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Nail")|| col.gameObject.CompareTag("Ground"))
        {
            grounded=true;
            print("grounded");
            jumpCount = 2;
        }
    }
    void OnCollisionExit2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Nail")|| col.gameObject.CompareTag("Ground")){
            grounded=false;
            print("not grounded");
        }
    }*/

    

}
