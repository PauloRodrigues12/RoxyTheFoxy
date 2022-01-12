using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public LayerMask enemyMask;
    public float speed;
    Rigidbody2D myBody;
    Transform MyTrans;
    float myWidth, myHeight;
    void Start()
    {
        MyTrans = this.transform;
        myBody = this.GetComponent<Rigidbody2D>();
        SpriteRenderer mySprite = this.GetComponent<SpriteRenderer>();
        myWidth = this.GetComponent<SpriteRenderer>().bounds.extents.x;
        myHeight = this.GetComponent<SpriteRenderer>().bounds.extents.y;
    }

    void FixedUpdate()
    {
        Vector2 lineCastPos = MyTrans.position.toVector2() - MyTrans.right.toVector2() * myWidth + Vector2.up * .05f, myHeight;
        Debug.DrawLine(lineCastPos, lineCastPos + Vector2.down);
        bool isGrounded = Physics2D.Linecast(lineCastPos, lineCastPos + Vector2.down, enemyMask);
        Debug.DrawLine(lineCastPos, lineCastPos - MyTrans.right.toVector2() *.03f);
        bool isBlocked = Physics2D.Linecast(lineCastPos, lineCastPos - MyTrans.right.toVector2() * .03f, enemyMask) ;

        if (!isGrounded || isBlocked)
        {
            Vector3 currRot = MyTrans.eulerAngles;
            currRot.y += 180;
            MyTrans.eulerAngles = currRot;
        }

        Vector2 Myvol = myBody.velocity;
        Myvol.x = -MyTrans.right.x * speed;
        myBody.velocity = Myvol;
         
    }

    public void Hurt()
    {
        AudioManager.PlaySound("MouseDeath");
        Destroy(this.gameObject);
    }
}
