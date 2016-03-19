using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    
    private int gameStatus;

    private bool complete;
    private float time;
    private float bestTime = -1;

    public PlayerInfo playerInfo;
    public Text bestTimeText;
    public Text timeText;

    public void init()
    {
        gameStatus = GameStatus.opening;
        complete = false;
        time = 0;
        playerInfo.init();
        bestTimeText = GameObject.Find("BestTimeText").GetComponent<Text>();
        timeText = GameObject.Find("TimeText").GetComponent<Text>();
    }
	// Use this for initialization
	void Start ()
    {
        init();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (gameStatus == GameStatus.opening)
        {
            gameStatus = GameStatus.playing;
        } else if (gameStatus == GameStatus.playing)
        {
            if (Input.GetKeyDown(KeyCode.R)) init();
            if (!complete) time += Time.deltaTime;
            bestTimeText.text = "Best Time: " + bestTime.ToString();
            timeText.text = "Time: " + time.ToString();
        }
    }

    public void lose()
    {
        init();
    }

    public void win()
    {
        if (time < bestTime || bestTime == -1) bestTime = time;
        complete = true;
    }
}
