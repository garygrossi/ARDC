using UnityEngine;
using System.Collections;

public class AccleromterInput : MonoBehaviour {
	private float xSpeed = 3 * (float) 0.05;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetTouch(0).pressure > 0.5) {
			transform.Translate(0, 0, xSpeed);
		}
	}
}
