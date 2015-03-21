using UnityEngine;
using System.Collections;

public class ComponentExample : Grunt {

	// Use this for initialization
	void Start () {
		Publish("ComponentStarted", gameObject);
		PublishBool("ComponentStarted", gameObject);
	}

	
	
}
