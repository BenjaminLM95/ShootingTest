using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourBulletsGo : MonoBehaviour
{
    public GameObject bulletUR;
    public GameObject bulletUL;
    public GameObject bulletDR;
    public GameObject bulletDL;
    // Start is called before the first frame update
    

    private void shootFourBullets() 
    {
        GameObject tempBullet = Instantiate(bulletUR, transform.position, transform.rotation) as GameObject;
        Destroy(tempBullet, 5f);
        GameObject tempBullet2 = Instantiate(bulletUL, transform.position, transform.rotation) as GameObject;
        Destroy(tempBullet, 5f);
        GameObject tempBullet3 = Instantiate(bulletDR, transform.position, transform.rotation) as GameObject;
        Destroy(tempBullet, 5f);
        GameObject tempBullet4 = Instantiate(bulletDL, transform.position, transform.rotation) as GameObject;
        Destroy(tempBullet, 5f);
    }
       

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Bullet");
            shootFourBullets();
            this.gameObject.SetActive(false);
        }
    }

}
