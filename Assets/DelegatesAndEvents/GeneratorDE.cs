using UnityEngine;

public class GeneratorDE : MonoBehaviour {

	public GameObject bucket;
	public GameObject player;
	public GameObject other;

	private PlayerDE playerScript;
	private OtherDE otherScript;

	public PlayerDE PlayerScript {
		get {
			return playerScript;
		}
	}

	void Awake() {
		playerScript = player.GetComponent<PlayerDE>();
		otherScript = other.GetComponent<OtherDE>();
	}

	public void GenerateBucket() {
		var tempBucket = Instantiate(bucket);
		var pUO = tempBucket.GetComponent<PickUpObjectDE>();
		playerScript.AddBucket(pUO);
		otherScript.RegisterBucket(pUO);
		otherScript.BucketsOnGround++;
	}

}
