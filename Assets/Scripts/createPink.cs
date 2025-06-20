using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class createPink : MonoBehaviour
{
    public GameObject balonPrefab;
    public float spawnInterval = 1.5f;
    public float minX = -2.5f;
    public float maxX = 2.5f;
    public float spawnY = -5.5f;
   

    void Start()
    {
        StartCoroutine(SpawnBalloons());
    }

   
    IEnumerator SpawnBalloons()
    {
        while (true) 
        {
            float randomX = Random.Range(minX, maxX);
            Vector3 spawnPosition = new Vector3(randomX, spawnY, 0);
            GameObject newBalloon = Instantiate(balonPrefab, spawnPosition, Quaternion.identity);
            Rigidbody2D rb = newBalloon.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(0f, 5f);
            yield return new WaitForSeconds(spawnInterval);
           
        }       
    }
}
