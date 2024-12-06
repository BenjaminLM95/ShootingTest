using UnityEngine;


public class bulletMovement : MonoBehaviour
{
    Vector3 pos = new Vector3();
    float bulletSpeed = 5.0f;
    public GameObject someOtherGameObject;
    public GameObject levelInfo;
    public LevelManagment lM;
    public RaycastHit2D hit;
    public LayerMask obstacles;
    //public Vector3 gravity = new Vector3(0, -9.81f, 0); 

    // Start is called before the first frame update
    void Start()
    {
        levelInfo = GameObject.Find("LevelManagment");
        lM = levelInfo.GetComponent<LevelManagment>();
        someOtherGameObject = GameObject.Find("Aim shot");
        pos = ((transform.position - someOtherGameObject.transform.position) * -1).normalized;
        Debug.Log(transform.position + " initial XYZ");
        Debug.Log(someOtherGameObject.transform.position + "Aim shot position" );  

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += pos * bulletSpeed * Time.deltaTime;


        hit = Physics2D.Raycast(transform.position, pos, 0.4f, obstacles);
        if (hit)
        {
            pos = Vector3.Reflect(pos, hit.normal);
            Debug.Log("reflect"); 
        } 
    }    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Balloon")) 
        {
            lM.CountScore();  
            Debug.Log("Hit");            
            other.gameObject.SetActive(false); 
        }        

        if (other.gameObject.CompareTag("Block")) 
        {
            this.gameObject.SetActive(false);   
        }
               

    }
}
