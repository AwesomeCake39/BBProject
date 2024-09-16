using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    private int[,] levelData;

    public GameObject cubePrefab;
    public GameObject spikePrefab;

    private float frameTimer;
    private float startFrameTimer = 0.2f;
    private int songFrame;
    private bool songStart = false;
    private Camera mainCam;

    public int score = 0;



    // Start is called before the first frame update
    void Start()
    {
        frameTimer = startFrameTimer;
        mainCam = Camera.main;
        mainCam.transform.position = new Vector3(0,3,-2);

        levelData[0,0] = 5;
        levelData[0,1] = -2;
        levelData[0,2] = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            songStart = true;
            mainCam.transform.position = new Vector3(0,8,-9);
        }
        
        if(songStart) {
            frameTimer -= Time.deltaTime;

            if(frameTimer <= 0) {
                songFrame += 1;
                Instantiate(cubePrefab, new Vector3(UnityEngine.Random.Range(-2,3), 0.5f, 75), transform.rotation);
                frameTimer = startFrameTimer;
            }
        }
    }
}
