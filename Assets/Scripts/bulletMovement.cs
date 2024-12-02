using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class bulletMovement : MonoBehaviour
{
    Vector3 pos = new Vector3();
    float bulletSpeed = 5.0f;
    public GameObject someOtherGameObject;
    public GameObject levelInfo;
    public LevelManagment lM;
    public RaycastHit hit;
   
    // Start is called before the first frame update
    void Start()
    {
        levelInfo = GameObject.Find("LevelManagment");
        lM = levelInfo.GetComponent<LevelManagment>(); 
        someOtherGameObject = GameObject.Find("Aim shot");
        pos = ((transform.position - someOtherGameObject.transform.position) * -1).normalized;
         

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += pos * bulletSpeed * Time.deltaTime;        

       

        /*
        if(ray.collider != null) 
        {
            if (ray.collider.CompareTag("Mirror")) 
            {
                pos = Vector3.Reflect(pos, Vector3.left);
                Debug.Log("reflect"); 
            }
        } */
    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Balloon")) 
        {
            lM.CountScore();  
            Debug.Log("Hit");            
            other.gameObject.SetActive(false); 
        }

        if(other.gameObject.CompareTag("Mirror"))
        {
            pos = Vector3.Reflect(pos, Vector3.left);            
        }

        if (other.gameObject.CompareTag("MirrorVertical"))
        {
            pos = Vector3.Reflect(pos, Vector3.up);
        }

        if (other.gameObject.CompareTag("Block")) 
        {
            this.gameObject.SetActive(false);   
        }

    }
}
