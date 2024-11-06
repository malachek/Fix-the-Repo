using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float moveSpeed;

    [SerializeField] ScoreBoard scoreBoard;

    private void Awake()
    {
        
    }

    private void Update()
    {
        Movement();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Goal"))
        {
            ReachedGoal();
        }
        else if (col.gameObject.CompareTag("Enemy"))
        {
            PlayerHit();
        }
    }

    private void ReachedGoal()
    {
        this.gameObject.transform.position = GameObject.FindGameObjectWithTag("Home").transform.position;
        scoreBoard.Score();
    }

    private void PlayerHit()
    {
        //GameOver();
    }

    private void Movement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(moveX, moveY) * moveSpeed;
    }
}
