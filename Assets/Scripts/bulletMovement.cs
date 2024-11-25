using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class bulletMovement : MonoBehaviour
{
    Vector3 pos = new Vector3();
    float bulletSpeed = 5.0f;
    public GameObject someOtherGameObject;
    // Start is called before the first frame update
    void Start()
    {        
        someOtherGameObject = GameObject.Find("Aim shot");
        pos = ((transform.position - someOtherGameObject.transform.position) * -1).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += pos * bulletSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ballon")) 
        {
            Debug.Log("Colission"); 
            other.gameObject.SetActive(false); 
        }
    }
}
