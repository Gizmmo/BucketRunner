using UnityEngine;
using System.Collections.Generic;

public class PlayerComp : MonoBehaviour {
    bool holdingObject;
    private List<PickUpObjectComp> buckets = new List<PickUpObjectComp>();

    public void PickUpBucket() {
        buckets[0].PickUp(gameObject);
    }

    public void FillAllBuckets() {
         foreach(var objectScript in buckets) {
                objectScript.FillBucket();
            }
    }

    public void AddBucket(PickUpObjectComp p) {
        buckets.Add(p);
    }
    
    public bool HoldingObject {get; set;}
}
