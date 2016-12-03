using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	public GameObject ballPrefab;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		KeyCode mousePrimary = KeyCode.Mouse0;
		if(Input.GetKeyDown(mousePrimary)) {
			Instantiate(ballPrefab);
		}
	}
}
