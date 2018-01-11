using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyReplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		MyKeyFrame testKey = new MyKeyFrame (Vector3.up, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class MyKeyFrame {

	public float frameTime;
	public Vector3 position;
	public Quaternion rotation;


	public MyKeyFrame (Vector3 pos, Quaternion rot) {
		frameTime = Time.time;
		position = pos;
		rotation = rot;
	}

}