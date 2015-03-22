using UnityEngine;
using System.Collections.Generic;

public class PlayerBroadcast : MonoBehaviour {
    bool holdingObject;
    private List<GameObject> buckets = new List<GameObject>();
    
    void BucketPickedUp() {
        HoldingObject = true;
    }

    public void PickUpBucket() {
        buckets[0].BroadcastMessage("PickUp", gameObject);
    }

    void AddBucket(GameObject bucket) {
        buckets.Add(bucket);
    }

    public void FillAllBuckets() {
        foreach(var bucket in buckets) {
            bucket.BroadcastMessage("FillBucket");
        }
    }

    public bool HoldingObject {get; set;}
}
