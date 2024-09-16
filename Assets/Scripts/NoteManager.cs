using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public float Speed = 40f;
    private AudioSource audioData;

    
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new UnityEngine.Vector3(0,0, Speed * Time.deltaTime * -1);
    }

    void OnCollisionEnter() 
    {
        if(gameObject.tag == "HitNoteSolid")
        {
            audioData.Play();
           // Destroy(gameObject);
        }
    }
}
