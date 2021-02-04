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
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            rb.velocity = Vector2.up * 1.75f;
            
        }
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        Destroy(gameObject);
        isLive = false;
        Time.timeScale = 0;
    }
}
