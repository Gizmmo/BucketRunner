using UnityEngine;

public class PickUpObjectPubSub : Grunt {
    
    void OnEnable() {
    	GlobalSubscribe("Space", PickUp);
    }
    
    void PickUp(GameObject objectToFollow) {
        if(GlobalPublishBool("CanPickUp", gameObject)) {
            gameObject.transform.parent = objectToFollow.transform;
            GlobalPublish("PickUp", gameObject);
        }
    }
}
