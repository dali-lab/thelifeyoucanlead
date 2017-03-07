using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatTwoLabelScript : MonoBehaviour {
	public GameController controller;
	public Text text;

	// Use this for initialization
	void Start () {
		GameObject controllerObject = GameObject.Find ("GameController");
		text = gameObject.GetComponent<Text> ();

		if (controllerObject != null) {
			controller = controllerObject.GetComponent<GameController> ();
		}
	}

	// Update is called once per frame
	void Update () {
		var statTwoVal = controller.statTwo;

		text.text = "Stat 2: " + statTwoVal.ToString ();
	}
}
