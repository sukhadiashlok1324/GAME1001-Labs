using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int integer = 0;
        Debug.Log(integer);     // logs the value 0
        Debug.Log("integer");   // logs the word integer

        // We can add, subtract, multiply and divide whole numbers
        int a = 1;
        int b = 2;
        Debug.Log(a + b);
        Debug.Log(a - b);
        Debug.Log(a * b);
        Debug.Log(a / b);

        // Integers round *down* to the nearest whole number "truncation"
        int n = (int)0.99999;
        Debug.Log(n);

        // We can also add, subtract, multiply and divide decimal numbers!
        float c = 1.0f;
        float d = 2.0f;
        Debug.Log(c + d);
        Debug.Log(c - d);
        Debug.Log(c * d);
        Debug.Log(c / d);
    }

    // The value in the inspector will override whatever value we have here
    // (So x will be -5 instead of 10000000)
    [SerializeField] float x = 10000000.0f;
    // Challenge:
    // Make a variable called y that changes the y-coordinate of the transform.
    [SerializeField] float y = 0.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(x, y, 0.0f);
    }
}
