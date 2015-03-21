using UnityEngine;

public class PickUpObjectPubSub : Grunt {
    
    void OnEnable() {
    	Subscribe("Space", PickUp);
    }
    
    void PickUp(GameObject objectToFollow) {
        if(PublishBool("CanPickUp", gameObject)) {
            gameObject.transform.parent = objectToFollow.transform;
            Publish("PickUp", gameObject);
        }
    }
}
