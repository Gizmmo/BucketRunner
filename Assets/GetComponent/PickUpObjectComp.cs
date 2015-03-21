using UnityEngine;

public class PickUpObjectComp : MonoBehaviour {
    public GameObject player;
    public GameObject other;

    private OtherComp otherScript;
    private PlayerComp playerScript;

    void Start() {
        otherScript = other.GetComponent<OtherComp>();
        playerScript = player.GetComponent<PlayerComp>();
    }

    public void PickUp(GameObject objectToFollow) {
        if(!playerScript.HoldingObject) {
            gameObject.transform.parent = objectToFollow.transform;
            otherScript.BucketPickUp();
            playerScript.HoldingObject = true;
        }
    }
}
