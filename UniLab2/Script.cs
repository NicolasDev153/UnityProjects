using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    /* This script gets input from the user
     * then converts it(string type input) to integer
     * and checks it with if/else statements
     * and after that outputs the corresponding answer to the console
     */
    string input;
    int result;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        result = Convert.ToInt32(input);

        // Boolean logic with if/else //
      
        if (result % 2 == 0 && result % 3 == 0)
        {
            Debug.Log("result is even and multiple of 3");
        }
        else if (result % 2 == 0 && result % 3 == 1)
        {
            Debug.Log("result is even but not multiple of 3");
        }
        else if (result % 2 == 1 && result % 3 == 0)
        {
            Debug.Log("result is odd and multiple of 3");
        }
        else if (result % 2 == 1 && result % 3 == 1)
        {
            Debug.Log("result is neither even,odd or multiple of 3");
        }
        else
        {
            Debug.Log("Invalid Input, please try again with integer(0-9) input");
        }
    }

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);

    }
}
