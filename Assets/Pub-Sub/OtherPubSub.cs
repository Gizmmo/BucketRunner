using UnityEngine;

public class OtherPubSub : Manager {
    int waterLevel = 0;
    
    void OnEnable () {
        RegisterBuckets();
    }

    void RegisterBuckets() {
        Subscribe("PickUp", HandleOnPickUp);
        SubscribeBool("CanPickUp", HandleCanPickUp);
    }

    bool HandleCanPickUp(GameObject g) {
        return waterLevel < 3;
    }

    void HandleOnPickUp(GameObject g) {
        waterLevel++;
        Debug.Log("Water level increased");
    }

}
