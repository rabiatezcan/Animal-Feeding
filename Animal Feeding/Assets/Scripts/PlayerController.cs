using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    float playerSpeed = 10f;
    float xRange = 16;
    public GameObject foodPrefab; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (gameObject.transform.position.x <= -xRange)
        {
            gameObject.transform.position = new Vector3(-xRange, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if(gameObject.transform.position.x >= xRange)
        {
            gameObject.transform.position = new Vector3(xRange, gameObject.transform.position.y, gameObject.transform.position.z);
        } 
        gameObject.transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerSpeed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 foodPos = new Vector3(transform.position.x, 2, transform.position.z);
            Instantiate(foodPrefab, foodPos, Quaternion.identity);
        }
    }
}
