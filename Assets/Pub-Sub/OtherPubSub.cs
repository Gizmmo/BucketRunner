using UnityEngine;

public class OtherPubSub : Manager {
    int waterLevel = 0;
    int bucketsOnGround;
    
    void OnEnable () {
        RegisterBuckets();
    }

    void RegisterBuckets() {
        GlobalSubscribe("PickUp", HandleOnPickUp);
        GlobalSubscribeBool("CanPickUp", HandleCanPickUp);
        GlobalSubscribe("FillBucket", HandleOnFillBucket);
        GlobalSubscribe("BucketAdded", HandleBucketAdded);
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
