using UnityEngine;


public class Aim_direction : MonoBehaviour
{
    public GameObject player;   

    // Start is called before the first frame update
    void Start()
    {
        transform.position = player.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePosition - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; 
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        

    }
}
