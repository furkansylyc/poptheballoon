using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createGreen : MonoBehaviour
{
    public GameObject balonPrefab;
    public float spawnInterval = Random.Range(2f,5f);
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
