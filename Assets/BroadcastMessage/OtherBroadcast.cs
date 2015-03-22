using UnityEngine;

public class OtherBroadcast : MonoBehaviour {
    int waterLevel;
    int bucketsOnGround;

    void BucketFilled() {
        waterLevel++;
    }

    void BucketPickedUp() {
    	bucketsOnGround++;
    }

    void AddBucket() {
    	bucketsOnGround++;
    }
}
