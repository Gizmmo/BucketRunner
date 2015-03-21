using UnityEngine;
using System;
using System.Collections.Generic;

public static class EventHandler {
	static readonly Dictionary<string, Action<GameObject>> events = new Dictionary<string, Action<GameObject>>();

	public static void Publish(string emitMessage, GameObject obj) {
		if(events.ContainsKey(emitMessage)) {
			if(events[emitMessage] != null)
				events[emitMessage](obj);
		}
	}

	public static Action<GameObject> Subscribe(string emitMessage) {
		if(!events.ContainsKey(emitMessage)) {
			events.Add(emitMessage, Action<GameObject>);
		}
		return events[emitMessage];

	}
}
