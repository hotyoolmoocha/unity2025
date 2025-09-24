using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carcontroller : MonoBehaviour
{
    float speed = 0f;
    public float decreaseRatio = 0.98f;
    public float speedRatio = 1.0f;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {

        Application.targetFrameRate = 4;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //this.speed = 0.2f;
            this.startPos = Input.mousePosition;
        }

        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;
            this.speed = swipeLength/speedRatio;
        }
            transform.Translate(this.speed, 0, 0);
        this.speed *= decreaseRatio;
    }
}
