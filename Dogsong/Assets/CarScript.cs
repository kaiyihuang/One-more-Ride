using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour {
	public bool moving = false;
	void Start()
	{
		
		StartCoroutine (fuckthis());
		//MoveObject(new Vector3 (1160.12f, 601.1f, -351.055f), new Vector3 (525f, 601f, 258f), 12.0f);
		//RotateLeft (10f);
		//StartCoroutine(MoveFromTo (new Vector3 (525f, 601f, 258f),new Vector3 (385f, 601f, -5829f), 60.0f));
		//StartCoroutine(RotateRight(9f));
		//MoveFromTo (new Vector3 (385f, 601f, -5829f),new Vector3 (-1257f, 601f, -5829f), 15.0f);
		//RotateRight(9f);
		//MoveFromTo (new Vector3 (-1257f, 601f, -5829f),new Vector3 (-1257f, 601f, -4424f), 25.0f);
	}
	void Update()
	{
	}
	void MoveObject(Vector3 pointA, Vector3 pointB, float time ){
			float t = 0f;
			while (t < 1f){
				t += Time.deltaTime / time; // sweeps from 0 to 1 in time seconds
				transform.position = Vector3.Lerp(pointA, pointB, t); // set position proportional to t
			}
			moving = false; // finished moving


	}
	IEnumerator fuckthis()
	{
		
		float time = 10.0f;
		if (!moving){ // do nothing if already moving
			moving = true; // signals "I'm moving, don't bother me!"
			float t = 0f;
			while (t < 1f){
				t += Time.deltaTime / time; // sweeps from 0 to 1 in time seconds
				transform.position = Vector3.Lerp(new Vector3 (1160.12f, 601.1f, -351.055f), new Vector3 (525f, 601f, 258f), t); // set position proportional to t
				yield return 0;
			}
			moving = false; // finished moving

		}
		transform.position = new Vector3 (525f, 601f, 258f);
		time = 4.0f;
		if (!moving){ // do nothing if already moving
			moving = true; // signals "I'm moving, don't bother me!"
			float t = 0f;
			while (t < 1f){
				t += Time.deltaTime / time; // sweeps from 0 to 1 in time seconds
				transform.Rotate (-Vector3.up * Time.deltaTime * 30);
				yield return 0;
			}
			moving = false; // finished moving

		}
		time = 60.0f;
		if (!moving){ // do nothing if already moving
			moving = true; // signals "I'm moving, don't bother me!"
			float t = 0f;
			while (t < 1f){
				t += Time.deltaTime / time; // sweeps from 0 to 1 in time seconds
				transform.position = Vector3.Lerp(new Vector3 (525f, 601f, 258f),new Vector3 (385f, 601f, -5829f), t); // set position proportional to t
				yield return 0;
			}
			moving = false; // finished moving

		}
		transform.position = new Vector3 (385f, 601f, -5829f);
		time = 3.0f;
		if (!moving){ // do nothing if already moving
			moving = true; // signals "I'm moving, don't bother me!"
			float t = 0f;
			while (t < 1f){
				t += Time.deltaTime / time; // sweeps from 0 to 1 in time seconds
				transform.Rotate (Vector3.up * Time.deltaTime * 30);
				yield return 0;
			}
			moving = false; // finished moving

		}
		time = 15.0f;
		if (!moving){ // do nothing if already moving
			moving = true; // signals "I'm moving, don't bother me!"
			float t = 0f;
			while (t < 1f){
				t += Time.deltaTime / time; // sweeps from 0 to 1 in time seconds
				transform.position = Vector3.Lerp(new Vector3 (385f, 601f, -5829f),new Vector3 (-1257f, 601f, -5829f), t); // set position proportional to t
				yield return 0;
			}
			moving = false; // finished moving

		}
		transform.position = new Vector3 (-1257f, 601f, -5829f);
		time = 3.0f;
		if (!moving){ // do nothing if already moving
			moving = true; // signals "I'm moving, don't bother me!"
			float t = 0f;
			while (t < 1f){
				t += Time.deltaTime / time; // sweeps from 0 to 1 in time seconds
				transform.Rotate (Vector3.up * Time.deltaTime * 30);
				yield return 0;
			}
			moving = false; // finished moving

		}
		time = 17.0f;
		if (!moving){ // do nothing if already moving
			moving = true; // signals "I'm moving, don't bother me!"
			float t = 0f;
			while (t < 1f){
				t += Time.deltaTime / time; // sweeps from 0 to 1 in time seconds
				transform.position = Vector3.Lerp(new Vector3 (-1257f, 601f, -5829f),new Vector3 (-1257f, 601f, -4424f), t); // set position proportional to t
				yield return 0;
			}
			moving = false; // finished moving

		}
		transform.position = new Vector3 (-1257f, 601f, -4424f);
		yield return new WaitForSeconds (3.0f);
		StartCoroutine(transition ());
	}
	public Transform doggo;
	public Transform doggo2;
	public Transform SecondCam;

	IEnumerator transition()
	{
		
		GameObject d = transform.FindChild ("car_exterior").gameObject;
		GameObject g = d.transform.FindChild ("R_car_door").gameObject;
		var k = g.GetComponent<Animation>();
		k.Play ();
		yield return new WaitForSeconds (1.8f);
		doggo.parent = null;
		GameObject meep = doggo.FindChild ("Main Camera").gameObject;
		ScreenFader.fadeIn = false;
		yield return new WaitForSeconds (16.5f);
		doggo.gameObject.SetActive(false);
		doggo2.gameObject.SetActive (true);
		meep.GetComponent<Camera> ().enabled = false;
		meep.GetComponent<AudioListener> ().enabled = false;
		SecondCam.GetComponent<Camera> ().enabled = true;
		SecondCam.GetComponent<AudioListener> ().enabled = true;
		ScreenFader.fadeIn = true;
		k.Rewind ();


		float time = 7f;
		float t = 0f;
		while (t < 1f){
			t += Time.deltaTime / time; // sweeps from 0 to 1 in time seconds
			transform.position = Vector3.Lerp(new Vector3 (-1257f, 601f, -4424f),new Vector3 (-1257f, 601f, -2939f), t); // set position proportional to t
			yield return 0;
		}

		yield return new WaitForSeconds (14.0f);
		ScreenFader.fadeIn = false;

	}

	}



