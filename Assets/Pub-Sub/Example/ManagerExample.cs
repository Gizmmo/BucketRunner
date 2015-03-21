using UnityEngine;

public class ManagerExample : Manager {

	void Awake() {
		// VoidAction events;
		// events = ComponentHandler;
		Subscribe("ComponentStarted", ComponentHandler);	
		SubscribeBool("ComponentStarted", SecondTest);
	}

	void ComponentHandler(GameObject g) {
		Debug.Log("Hello");
	}

	bool SecondTest(GameObject g) {
		Debug.Log("Second One");
		return true;
	}
}