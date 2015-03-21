using UnityEngine;

public class PlayerBroadcast : MonoBehaviour {
    bool holdingObject;
    
    void Update() {
    	if (Input.GetKeyDown("space")) {
            GameObject[] buckets = GameObject.FindGameObjectsWithTag("Bucket");
        	GameObject bucket = buckets[0];
            var objScript = bucket.GetComponent<PickUpObjectBroadcast>();
            objScript.PickUp(gameObject);
        }
    }
    
    void PickUpBucket() {
        HoldingObject = true;
    }

    public bool HoldingObject {get; set;}
}
