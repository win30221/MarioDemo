using UnityEngine;
using System.Collections;

public class Barrier : MonoBehaviour {

    public GameManager GM;

    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GM.init();
        }
    }
}
