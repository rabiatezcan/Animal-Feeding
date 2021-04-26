using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    float playerSpeed = 10f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        gameObject.transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerSpeed);
    }
}
