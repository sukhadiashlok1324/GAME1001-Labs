using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Computers make decisions with "if-statements"
        // We evaluate a true/false statement.
        if (2 + 2 == 3)
        {
            // We take this path if the condition is true
            Debug.Log("Condition is true!");
        }
        else
        {
            // We take this path if the condition is false
            Debug.Log("Condition is false!");
        }

        // General decision-making structure:
        if (true)
        {
            // true branch
        }
        else
        {
            // false branch
        }
    }

    [SerializeField] float x = 0.0f;
    [SerializeField] float y = 0.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(x, y, 0.0f);
    }
}
