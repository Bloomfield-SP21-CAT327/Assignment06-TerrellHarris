using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public GameObject player;
	public GameObject respawnPoint;

	public ParticleSystem winningParticles;

	public Text hud;
    public Canvas gameOverUI;
    public Text death;
	public int deathcounter = 0;

	//The amount of ellapsed time
	private float time = 0;

	//Flag that control the state of the game
	private bool isRunning = false;

	// Use this for initialization
	void Start () { InitGame(); }

	// Update is called once per frame
	void Update () {
		if (isRunning) {
			time += Time.deltaTime;
			hud.text = "Your time is " + (int)time;
		} else {
			hud.text = "Your time was " + time;
		}

		if(Input.GetButtonDown("Restart")) {
			RespawnPlayer();
		}
	}

	public void RespawnPlayer() {
		player.gameObject.SetActive(false);
		player.gameObject.transform.position = respawnPoint.transform.position;
        player.gameObject.SetActive(true);
		deathcounter = deathcounter + 1 ;

	}

	public void InitGame() {
		time = 0;
		isRunning = true;

		gameOverUI.enabled = false;
		winningParticles.Stop();
		winningParticles.Clear();
		RespawnPlayer();
	}

	public void Win() {
		isRunning = false;

        gameOverUI.enabled = true;
		death.text = "Deaths" + deathcounter;
		winningParticles.Play();
	}
}
