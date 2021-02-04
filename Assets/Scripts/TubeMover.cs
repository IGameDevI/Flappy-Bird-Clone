using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeMover : MonoBehaviour
{

    void Start()
    {
        Destroy(gameObject,7);
    }
    private void FixedUpdate()
    {
        transform.position += Vector3.left * 0.5f * Time.deltaTime;
    }
}
