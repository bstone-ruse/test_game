using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel(){

        Debug.Log("Level Completed Successfully");
        completeLevelUI.SetActive(true);

    }

    public void EndGame()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over.");
            Invoke("Restart", restartDelay);



        }
    }

    void Restart()
    {
        SceneManager.LoadScene("level1");

        //Reloads the current scene
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


}
