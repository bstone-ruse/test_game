using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;
    public GameObject completeLevelUI;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        Debug.Log("Level Completed Successfully");
        //completeLevelUI.SetActive(true);


    }


}
