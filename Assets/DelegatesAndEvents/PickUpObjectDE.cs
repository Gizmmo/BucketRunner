using UnityEngine;
using System.Collections;
using System;

public class PickUpObjectDE : MonoBehaviour {
    public event Action<GameObject> OnPickUp;
    public event Action<GameObject> OnFillBucket;
    
    public event Func<GameObject, bool> CanPickUp;

    private bool isFull;
    
    public void PickUp(GameObject objectToFollow) {
        if(IsAbleToPickUp()) {
            gameObject.transform.parent = objectToFollow.transform;
            if(OnPickUp != null)
                OnPickUp(gameObject);
        }
    }

    public void FillBucket() {
        isFull = true;
        if(OnFillBucket != null)
            OnFillBucket(gameObject);
    }
    
    bool IsAbleToPickUp() {
        if(CanPickUp == null)
            return true;
        
        foreach(Func<GameObject, bool> check in CanPickUp.GetInvocationList()) {
            if (check(gameObject) == false)
                return false;
        }
        
        return true;
    }

    void OnDisable() {
    	OnPickUp = null;
    }
}
