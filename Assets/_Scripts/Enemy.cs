using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int speed = 3;
    private Rigidbody2D rb2DEnemy;
    private Transform playerTransform;

    public bool isStoped = false;

    [SerializeField] private GameObject crabDead;

    public event Action OnDie =  null;
    // Start is called before the first frame update
    void Start()
    {
        rb2DEnemy = GetComponent<Rigidbody2D>();
        Player player = FindAnyObjectByType<Player>();
        if (player != null)
        {
            playerTransform = player.transform;
        }
        else
        {
            isStoped = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        MovedFromAttribute();
    }

    private void MovedFromAttribute()
    {
        if(isStoped || playerTransform == null)
        {
            rb2DEnemy.velocity = Vector3.zero;
            return;
        }

        Vector3 directionToPlayer = playerTransform.position - transform.position;
        rb2DEnemy.velocity = directionToPlayer.normalized * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Weapon"))
        {
            Instantiate(crabDead, transform.position, Quaternion.identity);
            Destroy(gameObject);
            if(OnDie != null)
            {
                OnDie();
            }
        }
    }
}
