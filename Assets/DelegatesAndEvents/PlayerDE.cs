using UnityEngine;
using System.Collections.Generic;

public class PlayerDE : MonoBehaviour {
    bool holdingObject;
    public List<PickUpObjectDE> buckets = new List<PickUpObjectDE>();
    
    void OnEnable() {
        RegisterBuckets();
    }

    public void AddBucket(PickUpObjectDE p) {
        buckets.Add(p);
        RegisterBucket(p);
    }

    void RegisterBuckets() {
        foreach(var bucket in buckets) {
            RegisterBucket(bucket);
        }
    }

    public void RegisterBucket(PickUpObjectDE bucket) {
        bucket.OnPickUp -= HandleOnPickUp;
        bucket.CanPickUp -= HandleCanPickUp;
        bucket.OnPickUp += HandleOnPickUp;
        bucket.CanPickUp += HandleCanPickUp;
    }

    public void PickUpBucket() {
        buckets[0].PickUp(gameObject);
    }

    public void FillAllBuckets() {
        foreach(var objectScript in buckets) {
            objectScript.FillBucket();
        }
    }
    
    void HandleOnPickUp(GameObject g) {
        HoldingObject = true;
    }
    
    bool HandleCanPickUp(GameObject g) {
        return HoldingObject == false;
    }

    void OnDisable() {
    	foreach(var bucket in buckets) {
            bucket.OnPickUp -= HandleOnPickUp;
            bucket.CanPickUp -= HandleCanPickUp;
        }
    }
    
    
    public bool HoldingObject {get; set;}
}
