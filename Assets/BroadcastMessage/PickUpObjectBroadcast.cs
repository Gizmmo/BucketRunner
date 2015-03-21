using UnityEngine;

public class PickUpObjectBroadcast : MonoBehaviour {
    public GameObject player;
    public GameObject other;

    private OtherBroadcast otherScript;
    private PlayerBroadcast playerScript;

    void Start() {
        playerScript = player.GetComponent<PlayerBroadcast>();
    }

    public void PickUp(GameObject objectToFollow) {
        if(!playerScript.HoldingObject) {
            gameObject.transform.parent = objectToFollow.transform;
            other.BroadcastMessage("PickUpBucket");
            player.BroadcastMessage("PickUpBucket");
        }
    }
}
