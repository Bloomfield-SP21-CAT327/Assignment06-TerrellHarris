using UnityEngine;

public class GCWin : MonoBehaviour {
	public GameController gameController;

	void OnTriggerEnter(Collider other) { gameController.Win(); }
}
