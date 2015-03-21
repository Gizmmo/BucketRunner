using UnityEngine;
using System.Collections;

public class Other : MonoBehaviour {
    int waterLevel = 0;
    
    void OnEnable () {
        RegisterBuckets();
    }

    void RegisterBuckets() {
        GameObject[] buckets = GameObject.FindGameObjectsWithTag("Bucket");
        foreach(GameObject bucket in buckets) {
            PickUpObject objScript = bucket.GetComponent<PickUpObject>();
            objScript.OnPickUp -= HandleOnPickUp;
    		objScript.CanPickUp -= HandleCanPickUp;
            objScript.OnPickUp += HandleOnPickUp;
            objScript.CanPickUp += HandleCanPickUp;
            
        }
    }

    bool HandleCanPickUp(GameObject g) {
        return waterLevel < 3;
    }

    void HandleOnPickUp(GameObject g) {
        waterLevel++;
    }

    void OnDisable() {
    	GameObject[] buckets = GameObject.FindGameObjectsWithTag("Bucket");
        foreach(GameObject bucket in buckets) {
        	PickUpObject objScript = bucket.GetComponent<PickUpObject>();
    		objScript.OnPickUp -= HandleOnPickUp;
    		objScript.CanPickUp -= HandleCanPickUp;
    	}
    }

}
