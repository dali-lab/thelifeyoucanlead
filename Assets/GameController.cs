using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Zingweb.com for singleton stuffffffs
public class GameController : MonoBehaviour {
	public double statOne = 0.0;
	public double statTwo = 50.0;

	public Text statOneText;
	public Text statTwoText;


	// Use this for initialization
	void Start () {
		GameObject statOneTextObj = GameObject.Find ("stat1Label");
		statOneText = statOneTextObj.GetComponent<Text> ();

		GameObject statTwoTextObj = GameObject.Find ("stat2Label");
		statTwoText = statTwoTextObj.GetComponent<Text> ();

		statOneText.text = "Stat 1: " + statOne.ToString();
		statTwoText.text = "Stat 2: " + statTwo.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DoStatOneEffect() {
		statOne += 2.0 / Mathf.Pow((float)statOne + 1.0F, 1.5F);
		print (statOne);

		statOneText.text = "Stat 1: " + statOne.ToString();
	}

	public void DoStatTwoEffect() {
		statTwo -= 1.0;
		print (statTwo);

		statTwoText.text = "Stat 2: " + statTwo.ToString();
	}
}
