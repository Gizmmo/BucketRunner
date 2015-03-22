using UnityEngine;

public class PickUpObjectPubSub : Grunt {
    private bool isFull;

    void OnEnable() {
    	GlobalSubscribe("PickUpTriggered", PickUp);
    	GlobalSubscribe("FillAllBuckets", FillBucket);
    	GlobalPublish("BucketAdded", gameObject);
    }
    
    void PickUp(GameObject objectToFollow) {
        if(GlobalPublishBool("CanPickUp", gameObject)) {
            gameObject.transform.parent = objectToFollow.transform;
            GlobalPublish("PickUp", gameObject);
        }
    }

    void FillBucket(GameObject g) {
    	isFull = true;
    	Publish("FillBucket", gameObject);
    }
}
