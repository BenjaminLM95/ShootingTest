using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class PlayerController : MonoBehaviour
{
    public GameObject aimPoint;
    public GameObject bullet; 
    private Vector3 aimPosition;
    private Vector3 directionToTarget = new Vector3();
    private Vector3 adjustPos = new Vector3(0.0f, 0, 0); 
    // Start is called before the first frame update
    void Start()
    {
        aimPosition = transform.position - aimPoint.transform.position;
        Debug.Log(aimPosition.magnitude);
        directionToTarget = (aimPoint.transform.position - this.transform.position).normalized;
        Debug.Log(directionToTarget.magnitude); 

    }

    // Update is called once per frame
    void Update()
    {
        directionToTarget = (aimPoint.transform.position - this.transform.position).normalized;

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Shoot(); 
        }

        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position + adjustPos, transform.position + directionToTarget);
        directionToTarget = (aimPoint.transform.position - this.transform.position).normalized;
    }

    private void Shoot() 
    {
        GameObject tempBullet = Instantiate(bullet, transform.position + directionToTarget, transform.rotation) as GameObject;        
        Destroy(tempBullet, 5f);
    }
}
