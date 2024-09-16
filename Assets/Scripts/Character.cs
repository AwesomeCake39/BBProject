using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UIElements;

public class Character : MonoBehaviour
{
    private CharacterController characterController;
    private float speed = 0;
    public float Sensitivity = 5f;
    private bool songStart = false;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) & !songStart) {
            speed = Sensitivity;
            songStart = true;
        }

        Vector3 mousePos = Input.mousePositionDelta;
        transform.position = transform.position + new Vector3(mousePos.x * speed * Time.deltaTime, 0, 0);

        if (transform.position.x >= 2.2) transform.position = new Vector3(2.2f, transform.position.y, transform.position.z);
        else if  (transform.position.x <= -2.2) transform.position = new Vector3(-2.2f, transform.position.y, transform.position.z);

    }
}
