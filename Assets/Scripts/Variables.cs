using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Surrounding text in double-quotes will log the text,
        // whereas logging a variable will output its value
        int integer = 0;
        Debug.Log(integer);     // outputs 0
        Debug.Log("integer");   // outputs integer
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
