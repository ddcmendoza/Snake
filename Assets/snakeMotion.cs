using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeMotion : MonoBehaviour
{
    // Start is called before the first frame update
    public float xPos,yPos,xVel,yVel;
    void Start()
    {
        xPos = 0;
        yPos = 0;
        xVel = 0;
        yVel = .01F;
    }

    // Update is called once per frame
    void Update()
    {
        xPos = xPos + xVel;
        yPos = yPos + yVel;
        Debug.Log(xPos);
        Debug.Log(yPos);
    }
}
