using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeSpawner : MonoBehaviour
{
    public Bird bird;
    public GameObject tube;
    
     void Start()
     {
         StartCoroutine(SpawnObject());
     }
    
    public IEnumerator SpawnObject()
    {
        while (bird.isLive == true)
        {
            Instantiate(tube, new Vector3(1f, Random.Range(-0.8f, 0f),0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
