using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{

    //Credits should be a public function
    public void Quit ()
    {

        Debug.Log("Exiting Game");
        Application.Quit();

    }
}