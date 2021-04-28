using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    float speed;
    float topBound = 30;
    float bottomBound = -10; 
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(10, 40);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if(gameObject.transform.position.z > topBound || gameObject.transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
