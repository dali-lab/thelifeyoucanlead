using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatOneLabelScript : MonoBehaviour {
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
		var statOneVal = controller.statOne;

		text.text = "Stat 1: " + statOneVal.ToString ();
	}
}
