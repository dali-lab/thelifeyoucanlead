using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public double statOne = 0.0;
	public double statTwo = 50.0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DoStatOneEffect() {
		statOne += 2.0 / Mathf.Pow((float)statOne + 1.0F, 1.5F);
		print (statOne);
	}

	public void DoStatTwoEffect() {
		statTwo -= 1.0;
		print (statTwo);
	}
}
