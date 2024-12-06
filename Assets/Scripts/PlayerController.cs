using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public GameObject aimPoint;
    public GameObject bullet; 
    private Vector3 aimPosition;
    private Vector3 directionToTarget = new Vector3();
    private Vector3 adjustPos = new Vector3(0.0f, 0, 0);
    public int mxShots; 
    public int shots;
    public LevelManagment lm;
    public GameObject txtInfo; 
    // Start is called before the first frame update
    void Start()
    {
        lm = txtInfo.GetComponent<LevelManagment>();
        aimPosition = transform.position - aimPoint.transform.position;
        Debug.Log(aimPosition.magnitude);
        directionToTarget = (aimPoint.transform.position - this.transform.position).normalized;
        Debug.Log(directionToTarget.magnitude);        
        shots = mxShots; 
    }

    // Update is called once per frame
    void Update()
    {
        directionToTarget = (aimPoint.transform.position - this.transform.position).normalized;

        if (Input.GetKeyDown(KeyCode.Space) && shots > 0 && !lm.win) 
        {
            shots--;
            lm.updatePoints(); 
            Shoot();
            
        }

        
    }
    /*
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position + adjustPos, transform.position + directionToTarget);
        directionToTarget = (aimPoint.transform.position - this.transform.position).normalized;
    }  */

    private void Shoot() 
    {
        GameObject tempBullet = Instantiate(bullet, transform.position + directionToTarget, transform.rotation) as GameObject;        
        Destroy(tempBullet, 8f);
        Debug.Log(directionToTarget + " Direction to Target"); 
    }

    


}
