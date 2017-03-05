using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatTwoLabelScript : MonoBehaviour {
	public GameController controller;
	public string text;

	// Use this for initialization
	void Start () {
		GameObject controllerObject = GameObject.Find ("GameController");

		if (controllerObject != null) {
			controller = controllerObject.GetComponent<GameController> ();
		}
	}

	// Update is called once per frame
	void Update () {
		var statTwoVal = controller.statTwo;
		print (statTwoVal);

		text = "Stat 2: " + statTwoVal.ToString ();
	}
}
