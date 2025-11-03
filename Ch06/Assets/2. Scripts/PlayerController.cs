using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    public float JumpForce = 500f;
    public float walkForce = 30f;
    public float maxWalkSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&
            rb.velocity.y == 0){ 
      
            rb.AddForce(transform.up * JumpForce);
            animator.SetTrigger("Jump Trigger");
        }

        int key = 0;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;

        float speedX = Mathf.Abs(rb.velocity.x);
        if (speedX < maxWalkSpeed)
        {
            rb.AddForce(transform.right * key * walkForce);
        }

        if(key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if (rb.velocity.y == 0)
        {
            animator.speed = speedX / 2.0f;
        }

        animator.speed = speedX/2;

        if(transform.position.y< -10)
        {
            string sceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("sceneName");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("Goal");
        SceneManager.LoadScene("Clear Scene");
    }

}
