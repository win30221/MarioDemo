using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public Transform character;

    private Vector3 moveTemp;

    float speed = 1;
    float xDifference;
    float yDifference;
    float movementThreshold = 0;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (character.transform.position.x > transform.position.x)
        {
            xDifference = character.transform.position.x - transform.position.x;
        }
        else {
            xDifference = transform.position.x - character.transform.position.x;
        }
        if (character.transform.position.y > transform.position.y)
        {
            yDifference = character.transform.position.y - transform.position.y;
        }
        else {
            yDifference = transform.position.y - character.transform.position.y;
        }
        if (xDifference >= movementThreshold)
        {
            moveTemp = character.transform.position;
            if (moveTemp.x < 17) moveTemp.x = 17;
            if (moveTemp.x > 83) moveTemp.x = 83;
            if (moveTemp.y < 7) moveTemp.y = 7;
            moveTemp.z = -10;
            transform.position = Vector3.MoveTowards(transform.position, moveTemp, speed);
        }
    }
}
