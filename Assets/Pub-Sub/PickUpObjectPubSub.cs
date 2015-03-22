using UnityEngine;

public class PickUpObjectPubSub : Grunt {
    private bool isFull;

    void OnEnable() {
    	Subscribe("PickUpTriggered", PickUp);
    	Subscribe("FillAllBuckets", FillBucket);
    	Publish("BucketAdded", gameObject);
    }
    
    void PickUp(GameObject objectToFollow) {
        if(PublishBool("CanPickUp", gameObject)) {
            gameObject.transform.parent = objectToFollow.transform;
            Publish("PickUp", gameObject);
        }
    }

    void FillBucket(GameObject g) {
    	isFull = true;
    	Publish("FillBucket", gameObject);
    }
}
