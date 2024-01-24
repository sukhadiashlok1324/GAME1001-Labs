using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Allow user to drag-and-drop target into Enemy script from Inspector
    [SerializeField] Transform player;

    void Update()
    {
        // If the distance between the player and the enemy is less than 5 units:
        if (Vector3.Distance(transform.position, player.position) < 5.0f)
        {
            // Move towards the player at 5 units per second!
            transform.position = Vector3.MoveTowards(
                transform.position, 
                player.position,
                5.0f * Time.deltaTime);
        }
    }
}
