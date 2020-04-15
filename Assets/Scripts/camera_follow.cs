using UnityEngine;
using System.Collections;

public class camera_follow : MonoBehaviour
{

    //define player game object
    public GameObject player;

    //wait for lateupdate
    void LateUpdate()
    {
        //define start and end of level. 
        //This will detach the camera from the player until it enters the range again

        if (player.transform.position.x > 0f )
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, -10f);
        }
    }

}