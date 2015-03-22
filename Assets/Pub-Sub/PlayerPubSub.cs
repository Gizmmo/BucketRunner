using UnityEngine;

public class PlayerPubSub : Manager {
    bool holdingObject;
    
    void OnEnable() {
        RegisterBuckets();
    }

    void RegisterBuckets() {
    	Subscribe("PickUp", HandleOnPickUp);
        SubscribeBool("CanPickUp", HandleCanPickUp);
    }

    public void PickUpBucket() {
        Publish("PickUpTriggered", gameObject);
    }

    public void FillAllBuckets() {
        Publish("FillAllBuckets", gameObject);
    }
    
    void HandleOnPickUp(GameObject g) {
        HoldingObject = true;
    }
    
    bool HandleCanPickUp(GameObject g) {
        return HoldingObject == false;
    }    
    
    public bool HoldingObject {get; set;}
}
