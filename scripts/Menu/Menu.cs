using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public Details details;
    
    public void startGame()
    {
        details.day = 0;
        details.noFound = 0;
        for (int i = 0; i < details.faePerson.Length; i++)
        {
            details.faePerson[i] = false;
        }
        for (int i = 0; i < details.found.Length; i++)
        {
            details.found[i] = false;
        }
        SceneManager.LoadScene(1);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void credits()
    {
        SceneManager.LoadScene(2);
    }
}
