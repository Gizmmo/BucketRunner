using UnityEngine;

public class GeneratorComp : MonoBehaviour {

	public GameObject bucket;
	public GameObject player;
	public GameObject other;

	private PlayerComp playerScript;
	private OtherComp otherScript;

	public PlayerComp PlayerScript {
		get {
			return playerScript;
		}
	}

	void Awake() {
		playerScript = player.GetComponent<PlayerComp>();
		otherScript = other.GetComponent<OtherComp>();
	}

	public void GenerateBucket() {
		var tempBucket = Instantiate(bucket);
		PickUpObjectComp pUO = tempBucket.GetComponent<PickUpObjectComp>();
		pUO.player = player;
		pUO.other = other;
		pUO.GetScripts();
		playerScript.AddBucket(pUO);
		otherScript.BucketsOnGround++;
	}
}
