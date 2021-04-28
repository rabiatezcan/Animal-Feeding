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
        speed = Random.Range(10, 25);
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

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
