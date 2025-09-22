using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RoulleteController : MonoBehaviour
{
    float rotSpeed = 1.0f;
    public float startSpeed = 20f;
    public float dRation = 0.99f;
    public float minSpeed = 0.1f;
    bool startDecrease = false;


    // Start is called before the first frame update
    void Start()
    {

        Application.targetFrameRate = 60;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10f;
        }

        transform.Rotate(0,0,-rotSpeed);
        this.rotSpeed *= this.dRation;
    }

        if(this.rotSpeed<minSpeed){

    }

}
