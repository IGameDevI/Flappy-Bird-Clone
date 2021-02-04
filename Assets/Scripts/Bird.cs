using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private GameObject bird;

    private Rigidbody2D rb;

    public bool isLive = true;
    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.Find("Bird");
        rb = bird.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            rb.velocity = Vector2.up * 1.75f;
            
        }
    }
}
