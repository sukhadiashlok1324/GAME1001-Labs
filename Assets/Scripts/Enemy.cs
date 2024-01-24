using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform player;

    float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        // If there's less than 5 units between the player and the enemy:
        if (Vector3.Distance(transform.position, player.position) < 5.0f)
        {
            // Move the enemy towards the player based on the enemy's speed!
            transform.position = Vector3.MoveTowards(
                transform.position,
                player.position,
                speed * Time.deltaTime);
        }
    }
}
