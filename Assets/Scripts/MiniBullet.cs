using UnityEngine;

public class MiniBullet : MonoBehaviour
{
    public Vector3 setDirection;
    public GameObject levelInfo;
    public LevelManagment lM;
    // Start is called before the first frame update
    void Start()
    {
        levelInfo = GameObject.Find("LevelManagment");
        lM = levelInfo.GetComponent<LevelManagment>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += setDirection * Time.deltaTime; 
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
