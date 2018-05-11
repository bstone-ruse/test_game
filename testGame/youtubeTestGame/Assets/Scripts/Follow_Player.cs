using UnityEngine;

public class Follow_Player : MonoBehaviour {

    public Transform player;
    public Vector3 offset;  

    // Update is called once per frame
	void Update ()
    {
        //Debug.Log(player.position);

        //the position of the camera = players positoin.
        transform.position = player.position + offset;
        //sudo first person view

	}
}
