using UnityEngine;

public class PlayerComp : MonoBehaviour {
    bool holdingObject;
    
    void Update() {
    	if (Input.GetKeyDown("space")) {
            GameObject[] buckets = GameObject.FindGameObjectsWithTag("Bucket");
        	GameObject bucket = buckets[0];
            PickUpObjectComp objScript = bucket.GetComponent<PickUpObjectComp>();
            objScript.PickUp(gameObject);
        }
    }
    
    public bool HoldingObject {get; set;}
}
