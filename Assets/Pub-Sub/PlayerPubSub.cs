using UnityEngine;

public class PlayerPubSub : Manager {
    bool holdingObject;
    
    void OnEnable() {
        RegisterBuckets();
    }

    void RegisterBuckets() {
    	GlobalSubscribe("PickUp", HandleOnPickUp);
        GlobalSubscribeBool("CanPickUp", HandleCanPickUp);
    }

    public void PickUpBucket() {
        GlobalPublish("PickUpTriggered", gameObject);
    }

    public void FillAllBuckets() {
        GlobalPublish("FillAllBuckets", gameObject);
    }
    
    void HandleOnPickUp(GameObject g) {
        HoldingObject = true;
    }
    
    bool HandleCanPickUp(GameObject g) {
        return HoldingObject == false;
    }    
    
    public bool HoldingObject {get; set;}
}
