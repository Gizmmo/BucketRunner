using UnityEngine;

public class GeneratorPubSub : MonoBehaviour {

	public GameObject bucket;
	public GameObject player;

	private PlayerPubSub playerScript;

	public PlayerPubSub PlayerScript {
		get {
			return playerScript;
		}
	}

	void Awake() {
		playerScript = player.GetComponent<PlayerPubSub>();
	}

	public void GenerateBucket() {
		var tempBucket = Instantiate(bucket);
	}
}
