using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    public GameObject aimPoint;
    private Vector3 aimPosition;
    private Vector3 directionToTarget = new Vector3();
    private Vector3 adjustPos = new Vector3(0.5f, 0, 0); 
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
        //aimPoint.transform.LookAt(this.transform);
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position + adjustPos, transform.position + directionToTarget);
        directionToTarget = (aimPoint.transform.position - this.transform.position).normalized;
    }
}
