using UnityEngine;

public class OtherComp : MonoBehaviour {
    int waterLevel;
    int bucketsOnGround;

    public void BucketFilled() {
        waterLevel++;
    }

    public int BucketsOnGround {get; set;}

}
