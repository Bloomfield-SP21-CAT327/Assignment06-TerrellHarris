using UnityEngine;

public class Hazard : MonoBehaviour {
	public GameObject respawnPoint;

	void OnTriggerEnter(Collider other) {
		other.gameObject.SetActive(false); // If using Standard Assets player controller
		other.gameObject.transform.position = respawnPoint.transform.position;
		other.gameObject.SetActive(true);
	}
}
