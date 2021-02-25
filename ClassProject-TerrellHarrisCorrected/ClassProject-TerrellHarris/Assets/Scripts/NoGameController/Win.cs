using UnityEngine;

public class Win : MonoBehaviour {
	public ParticleSystem particleCannon;

	void Start () { particleCannon.Stop(); }

	void OnTriggerEnter(Collider other) { particleCannon.Play(); }
}
