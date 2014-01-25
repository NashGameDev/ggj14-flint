﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public GameObject cleanerObject;
	public GameObject gateSpawner;

	public List<GameObject> gatePrefabs = new List<GameObject>(); 

	private GameObject currentGate;
	private Transform gateOrigin;


	// prototype time functions
	float interval = 1f; //for 1 second
	float timer;


	void Awake() {
		Debug.Log ("I'm awake!");
		gateOrigin = gateSpawner.transform;
	}
	// Use this for initialization
	void Start () {
		timer = Time.time + interval;
		SpawnGate();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time >= timer)
		{
			timer = Time.time + interval; //set the timer again
			SpawnGate();
		}
	}


	void SpawnGate() {
		//currentGate = (GameObject)Instantiate(gatePrefabs[Random.Range(0,3)]);  // cut scope and ship it!!!!
		currentGate = (GameObject)Instantiate(gatePrefabs[0]);
		currentGate.transform.position = gateOrigin.position;
	}
}
