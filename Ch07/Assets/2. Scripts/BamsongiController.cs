using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    public int forwardForce = 2000;
    public int upForce = 200;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        Shoot(new Vector3(0,200,2000));
        Destroy(gameObject, 10);
    }

    // Update is called once per frame
    void Update(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>()
    }
}
