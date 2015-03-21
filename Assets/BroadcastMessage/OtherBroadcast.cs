using UnityEngine;

public class OtherBroadcast : MonoBehaviour {
    int waterLevel;

    public void PickUpBucket() {
        waterLevel++;
        Debug.Log(waterLevel);
    }
}
