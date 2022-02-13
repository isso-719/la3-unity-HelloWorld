using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    string debugText = "Hello LiT!";

    int x = 10;
    int y = 5;
    int answer;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(debugText);

        answer = x + y;
        Debug.Log(answer);

        Debug.Log(123 + 456);
        Debug.Log("123" + "456");
    }
}
