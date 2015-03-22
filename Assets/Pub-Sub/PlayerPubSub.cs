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

    void Update() {
    	if (Input.GetKeyDown("space")) {
            GlobalPublish("Space", gameObject);
        }
    }
    
    void HandleOnPickUp(GameObject g) {
        HoldingObject = true;
        Debug.Log("Player Picked Up!");
    }
    
    bool HandleCanPickUp(GameObject g) {
        return HoldingObject == false;
    }    
    
    public bool HoldingObject {get; set;}
}
