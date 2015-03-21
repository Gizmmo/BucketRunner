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

    void Update() {
    	if (Input.GetKeyDown("space")) {
            Publish("Space", gameObject);
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
