using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagment : MonoBehaviour
{
    public int Points = 0;
    public int nMonsters = 0; 
    //public GameObject levelObj;
    public PlayerController pC;
    public GameObject player;
    public TextMeshProUGUI scoreTx;
    public int numberOfMonsters;
    public bool win = false;
    public string nextLevel;
    public TextMeshProUGUI WinLoseTx;

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
        if (nMonsters == numberOfMonsters)
        {
            win = true;
            Debug.Log("You win"); 
        }

        if (win) 
        {
            WinLoseTx.gameObject.SetActive(true);
            WinLoseTx.text = "You Win!!!"; 
            Invoke("levelComplete", 2f); 

        }
            

        if(pC.shots == 0 && nMonsters < numberOfMonsters) 
        {
            WinLoseTx.gameObject.SetActive(true);
            WinLoseTx.text = "You lost! Press 'M' to return to the menu or press 'R' to restart the level"; 
        }
    }

    public void CountScore() 
    {
        nMonsters++;
        updatePoints(); 
                
    }

    public void ShowUD()
    {
        scoreTx.text = "Shots: " + pC.shots + " Monsters Defeated: " + nMonsters + " Score: " + Points;
    }

    public void updatePoints() 
    {
        Points = nMonsters * 10 + ((pC.shots - pC.mxShots) * 2);
        if (Points < 0)
            Points = 0; 

        ShowUD(); 
    }

    public void levelComplete() 
    {
        SceneManager.LoadScene(nextLevel);
    }

}
