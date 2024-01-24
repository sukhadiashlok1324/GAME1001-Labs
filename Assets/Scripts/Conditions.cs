using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // "if-statements" let us make decisions based on true/false values
        // if the condition is *true*, we take the true branch
        // otherwise if the condition is *false*, we take the false branc
        if (1 + 2 == 4)
        {
            // "true branch"
            Debug.Log("Condition was true!");
        }
        else
        {
            // "false branch"
            Debug.Log("Condition was false!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 0.0f)
            GetComponent<SpriteRenderer>().color = Color.green;
        else
            GetComponent<SpriteRenderer>().color = Color.red;
    }
}
