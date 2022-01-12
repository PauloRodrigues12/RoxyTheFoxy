using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 100f;
    public float invincibleTimeAfterHurt = 2;
    public int damageToGive;
    public int healing;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    private PlayerHealthManager playerhealthmanager;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalMove = CrossPlatformInputManager.GetAxis("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            AudioManager.PlaySound("JumpSound");
            jump = true;
            animator.SetBool("IsJumping", true);
        }
    }

    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    public void Damage(int dmg)
    {
        playerhealthmanager.playerCurrentHealth -= dmg;
    }

    public void HitPlayer()
    {
        if (Random.value <= 0.5f)
        {
            AudioManager.PlaySound("HurtSound");
            rb2d.AddForce(Vector2.up * (controller.m_JumpForce * 0.9f));
            rb2d.AddForce(Vector2.right * (controller.m_JumpForce * 0.9f));
        }
        else
        {
            AudioManager.PlaySound("HurtSound");
            rb2d.AddForce(Vector2.up * (controller.m_JumpForce * 0.9f));
            rb2d.AddForce(Vector2.left * (controller.m_JumpForce * 0.9f));
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Enemy enemy = collision.collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            foreach (ContactPoint2D point in collision.contacts)
            {
                Debug.Log(point.normal);
                Debug.DrawLine(point.point, point.point + point.normal, Color.red, 10);
                if (point.normal.y >= 0.9f)
                {
                    enemy.Hurt();
                    gameObject.GetComponent<PlayerHealthManager>().HealPlayer(healing);
                }
                else
                {
                    gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
                }
            }
        }

        EagleEnemy eagleenemy = collision.collider.GetComponent<EagleEnemy>();
        if (eagleenemy != null)
        {
            foreach (ContactPoint2D point in collision.contacts)
            {
                Debug.Log(point.normal);
                Debug.DrawLine(point.point, point.point + point.normal, Color.red, 10);
                if (point.normal.y >= 0.9f)
                {
                    eagleenemy.Hurt();
                    gameObject.GetComponent<PlayerHealthManager>().HealPlayer(healing);
                }
                else
                {
                    gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(damageToGive);
                }
            }
        }
    }
}
