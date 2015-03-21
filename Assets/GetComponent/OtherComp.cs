using UnityEngine;

public class OtherComp : MonoBehaviour {
    int waterLevel;

    public void BucketPickUp() {
        waterLevel++;
        Debug.Log(waterLevel);
    }
}
