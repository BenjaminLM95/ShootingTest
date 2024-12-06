using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagement : MonoBehaviour
{
   public void goToMenu() 
    {
        SceneManager.LoadScene("Menu");
    }

    public void goToLevel1() 
    {
        SceneManager.LoadScene("Level_1");
    }

    public void goToLevel2() {
        SceneManager.LoadScene("Level_2");
    }
    public void goToLevel3() {
        SceneManager.LoadScene("Level_3");
    }

    public void goToInstructions() 
    {
        SceneManager.LoadScene("Instructions");
    }

    public void selectLevel()
    {
        SceneManager.LoadScene("ChooseLevel");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
