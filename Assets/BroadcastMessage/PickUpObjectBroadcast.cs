using UnityEngine;

public class PickUpObjectBroadcast : MonoBehaviour {
    public GameObject player;
    public GameObject other;

    private PlayerBroadcast playerScript;
    private bool isFull;

    void Start() {
        GetScripts();
    }

    void GetScripts() {
        playerScript = player.GetComponent<PlayerBroadcast>();
    }

    void PickUp(GameObject objectToFollow) {
        if(!playerScript.HoldingObject) {
            gameObject.transform.parent = objectToFollow.transform;
            other.BroadcastMessage("BucketPickedUp");
            player.BroadcastMessage("BucketPickedUp");
        }
    }

    void FillBucket() {
        isFull = true;
        other.BroadcastMessage("BucketFilled");
    }
}
