using UnityEngine;
using System.Collections;

public class OtherDE : MonoBehaviour {
    int waterLevel = 0;
    int bucketsOnGround;

    public void RegisterBucket(PickUpObjectDE bucket) {
        bucket.OnPickUp -= HandleOnPickUp;
		bucket.CanPickUp -= HandleCanPickUp;
        bucket.OnPickUp += HandleOnPickUp;
        bucket.CanPickUp += HandleCanPickUp;
        bucket.OnFillBucket += HandleOnFillBucket;
    }

    void HandleOnFillBucket(GameObject g) {
        waterLevel++;
    }

    bool HandleCanPickUp(GameObject g) {
        return waterLevel < 3;
    }

    void HandleOnPickUp(GameObject g) {
        bucketsOnGround--;
    }

    void OnDisable() {
    	GameObject[] buckets = GameObject.FindGameObjectsWithTag("Bucket");
        foreach(GameObject bucket in buckets) {
        	PickUpObjectDE objScript = bucket.GetComponent<PickUpObjectDE>();
    		objScript.OnPickUp -= HandleOnPickUp;
    		objScript.CanPickUp -= HandleCanPickUp;
    	}
    }

    public int BucketsOnGround {get; set;}

}
