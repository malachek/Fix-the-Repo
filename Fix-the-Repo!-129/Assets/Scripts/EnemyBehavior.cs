using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private Transform playerTransform;
    [SerializeField] float moveSpeed;
    
    void Start()
    {
        playerTransform = GameObject.FindObjectOfType<PlayerController>().transform;
    }
    
    void Update()
    {
        //look at player's position
        Vector2 direction = playerTransform.position - transform.position;
        float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));

        //move towards player's position
        transform.position = Vector2.MoveTowards(this.transform.position, playerTransform.position, moveSpeed * Time.deltaTime);
    }
}
