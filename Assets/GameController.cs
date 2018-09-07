using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {

    public TextMesh infoText;
    public Player player;

    private float gameTimer = 0f;
    private float restartTimer = 3f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(player.reachedFinishLine == false)
        {
            gameTimer += Time.deltaTime;
            infoText.text = "\n\nAvoid the Obstacles!\nPress space to jump!\nTime: " + Mathf.Floor(gameTimer);
        }
        else
        {
            infoText.text = "You Win!\nYou're Time: " + Mathf.Floor(gameTimer);

            restartTimer -= Time.deltaTime;
            if(restartTimer <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
	}
}
