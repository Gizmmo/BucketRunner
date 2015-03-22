using UnityEngine;

public class OtherPubSub : Manager {
    int waterLevel = 0;
    int bucketsOnGround;
    
    void OnEnable () {
        RegisterBuckets();
    }

    void RegisterBuckets() {
        Subscribe("PickUp", HandleOnPickUp);
        SubscribeBool("CanPickUp", HandleCanPickUp);
        Subscribe("FillBucket", HandleOnFillBucket);
        Subscribe("BucketAdded", HandleBucketAdded);
    }

    bool HandleCanPickUp(GameObject g) {
        return waterLevel < 3;
    }

    void HandleOnPickUp(GameObject g) {
        bucketsOnGround--;
    }

    void HandleBucketAdded(GameObject g) {
        bucketsOnGround++;
    }

    void HandleOnFillBucket(GameObject g) {
        waterLevel++;
    }

    public int BucketsOnGround {get; set;}
}
