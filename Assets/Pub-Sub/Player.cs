using UnityEngine;
using System.Collections;

public class PlayerPubSub : MonoBehaviour {
    bool holdingObject;
    
    void OnEnable() {
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

    void Update() {
    	if (Input.GetKeyDown("space")) {
            GameObject[] buckets = GameObject.FindGameObjectsWithTag("Bucket");
        	GameObject bucket = buckets[0];
            PickUpObject objScript = bucket.GetComponent<PickUpObject>();
            objScript.PickUp(gameObject);
        }
    }
    
    void HandleOnPickUp(GameObject g) {
        HoldingObject = true;
        Debug.Log("Player Picked Up!");
    }
    
    bool HandleCanPickUp(GameObject g) {
        return HoldingObject == false;
    }

    void OnDisable() {
    	GameObject[] buckets = GameObject.FindGameObjectsWithTag("Bucket");
        foreach(GameObject bucket in buckets) {
            PickUpObject objScript = bucket.GetComponent<PickUpObject>();
            objScript.OnPickUp -= HandleOnPickUp;
            objScript.CanPickUp -= HandleCanPickUp;
            
        }
    }
    
    
    public bool HoldingObject {get; set;}
}
