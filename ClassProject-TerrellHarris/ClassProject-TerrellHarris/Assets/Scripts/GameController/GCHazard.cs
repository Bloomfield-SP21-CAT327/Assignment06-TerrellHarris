using UnityEngine;

public class GCHazard : MonoBehaviour {
// 	private GameController gameControler;

// 	void Start () {
// //        gameControler = GameObject.Find("GameController").GetComponent<GameController>(); // Not the best option!
//         gameControler = GameObject.FindWithTag("GameController").GetComponent<GameController>();
// 	}
	
	void OnTriggerEnter(Collider other) { 
		//gameControler.RespawnPlayer(); 
		GameObject.FindWithTag("GameController").GetComponent<GameController>().RespawnPlayer();
	}
}
