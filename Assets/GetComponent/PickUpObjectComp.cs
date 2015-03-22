using UnityEngine;

public class PickUpObjectComp : MonoBehaviour {
    public GameObject player;
    public GameObject other;

    private OtherComp otherScript;
    private PlayerComp playerScript;
    private bool isFull;

    void Start() {
        GetScripts();
    }

    public void GetScripts() {
        otherScript = other.GetComponent<OtherComp>();
        playerScript = player.GetComponent<PlayerComp>();
    }

    public void PickUp(GameObject objectToFollow) {
        if(!playerScript.HoldingObject) {
            gameObject.transform.parent = objectToFollow.transform;
            otherScript.BucketsOnGround--;
            playerScript.HoldingObject = true;
        }
    }

    public void FillBucket() {
        isFull = true;
        otherScript.BucketFilled();
    }
}
