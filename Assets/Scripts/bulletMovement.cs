using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class bulletMovement : MonoBehaviour
{
    Vector3 pos = new Vector3();
    float bulletSpeed = 5.0f; 
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += pos * bulletSpeed * Time.deltaTime;
    }
}
