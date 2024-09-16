using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spikePrefab;

    private float spawnTimer;
    private float startSpawnTimer = 0.2f;

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        spawnTimer = startSpawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if(spawnTimer <= 0) {
            Instantiate(cubePrefab, new Vector3(Random.Range(-2,3), 0.5f, 75), transform.rotation);
            spawnTimer = startSpawnTimer;
        }
    }
}
