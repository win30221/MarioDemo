using UnityEngine;
using System.Collections;

public class PlayerInfo : MonoBehaviour {

    private bool isLive;
    public bool IsLive() { return isLive; }
    public float speed;
    public float jump;
    public int defaultJumpTimes;

    public void init()
    {
        isLive = true;
        transform.position = new Vector3(1.5f, 0, 0);
    }

    public void die()
    {
        isLive = false;
    }
    
}
