using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelManagment : MonoBehaviour
{
    public int Points = 0;
    public int nBallons = 0; 
    //public GameObject levelObj;
    public PlayerController pC;
    public GameObject player;
    public TextMeshProUGUI scoreTx;
    public int numberOfBallons;
    public bool win = false; 

    // Start is called before the first frame update
    void Start()
    {         
        pC = player.GetComponent<PlayerController>();
        ShowUD();
        Debug.Log("Running" + player);

    }

    // Update is called once per frame    
    private void Update()
    {
        if (nBallons == numberOfBallons)
        {
            win = true;
            Debug.Log("You win"); 
        }
    }

    public void CountScore() 
    {
        nBallons++;
        updatePoints(); 
        Debug.Log(Points);        
    }

    public void ShowUD()
    {
        scoreTx.text = "Shots: " + pC.shots + "Popped Ballons: " + nBallons + " Score: " + Points;
    }

    public void updatePoints() 
    {
        Points = nBallons * 10 + ((pC.shots - pC.mxShots));
        ShowUD(); 
    }

}
