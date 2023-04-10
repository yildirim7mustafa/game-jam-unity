using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player_Controller : MonoBehaviour
{
    [Header("Components")]
    public Rigidbody2D rb;
    public Animator animator;

    [Header("Gameplay")]
    public float speed;
    private Vector2 movement;

    private int healt = 6;

    void Start()
    {
        
    }


    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(
            movement.x * speed,
            movement.y * speed
            );

        runAnim();

        if (healt <= 0)
        {
            //Destroy(gameObject);
            SceneManager.LoadScene("DeadMenu");
            Key.Count = 0;

        }
    }
        
    private void runAnim()
    {
        if(movement.x != 0 || movement.y != 0)
        {
            animator.SetBool("isRunning",true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Debug.Log("damage");
            healt--;
        }
    }
}
