using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManagment : MonoBehaviour
{
    public int Points = 0;   
    //public GameObject levelObj;
    public PlayerController pC;
    public GameObject player;
    public TextMeshProUGUI scoreTx;

    // Start is called before the first frame update
    void Start()
    {         
        pC = player.GetComponent<PlayerController>();
        ShowUD();
        Debug.Log("Running" + player);

    }

    // Update is called once per frame    
    
    public void CountScore() 
    {
        Points++;        
        Debug.Log(Points);
        ShowUD(); 
    }
    
    public void ShowUD()
    {
        scoreTx.text = "Shots: " + pC.shots + " Score: " + Points;
    }

}
