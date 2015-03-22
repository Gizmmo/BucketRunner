using UnityEngine;
using System.Diagnostics;

public class DriverPubSub : MonoBehaviour {
	private int amount = 1;
	private GeneratorPubSub gen;
	private PlayerPubSub pScript;
	private Stopwatch stopwatch;

	// Use this for initialization
	void Start () {
		gen = GetComponent<GeneratorPubSub>();
		pScript = gen.PlayerScript;
		stopwatch = new Stopwatch();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.M)) {
			StartTimer();
			for(int i = 0; i < amount; i++) {
				gen.GenerateBucket();
			}
			EndTimer();
			amount *= 10;
		}

		if (Input.GetKeyDown(KeyCode.P)) {
			StartTimer();
            pScript.PickUpBucket();
            EndTimer();
        }

        if(Input.GetKeyDown(KeyCode.Space)) {
        	StartTimer();
        	pScript.FillAllBuckets();
        	EndTimer();
        }
	}


	void StartTimer() {
		stopwatch.Start();
	}

	void EndTimer() {
		stopwatch.Stop();
		UnityEngine.Debug.Log("code took " + stopwatch.ElapsedMilliseconds + " milliseconds");
		stopwatch.Reset();
	}
}
