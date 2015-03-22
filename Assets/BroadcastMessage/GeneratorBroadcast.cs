using UnityEngine;

public class GeneratorBroadcast : MonoBehaviour {

	public GameObject bucket;
	public GameObject player;
	public GameObject other;

	private PlayerBroadcast playerScript;

	public PlayerBroadcast PlayerScript {
		get {
			return playerScript;
		}
	}

	void Awake() {
		playerScript = player.GetComponent<PlayerBroadcast>();
	}

	public void GenerateBucket() {
		var tempBucket = Instantiate(bucket);
		PickUpObjectBroadcast pUO = tempBucket.GetComponent<PickUpObjectBroadcast>();
		pUO.player = player;
		pUO.other = other;
		pUO.BroadcastMessage("GetScripts");
		player.BroadcastMessage("AddBucket", tempBucket);
		other.BroadcastMessage("AddBucket");
	}
}
