using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Why did I have to make this new script? Last time I create script in assets
// moved to correct location, then tried to drag/drop but it wouldn't show up
public class PlayerControls : MonoBehaviour {

	private float speed;

	// Use this for initialization
	void Start () {
		speed = 2;
	}
	
	// Update is called once per frame
	void Update () {
		float axisX = Input.GetAxis("Horizontal");
		float axisY = Input.GetAxis("Vertical");
		
		// Would it not be better for me to use a Vector2 ?
		transform.Translate(new Vector3(axisX,axisY) * Time.deltaTime * speed);
	}
}
