﻿// -------------------------------------------------------------------------------------------

// Author: Colby Johnson

// Project: Roll Off!

// Last Updated: 02/07/2017

// Purpose: A script to identify player one

// -------------------------------------------------------------------------------------------

using UnityEngine;
using System.Collections;

public class PlayerOne : MonoBehaviour {

	public AudioClip[] hits;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {



	}
	
	// Update is called once per frame
	void Update () {

		
	
	}

	void OnTriggerEnter (Collider other) {

		audioSource = GetComponent<AudioSource>();

		if (other.tag == "Player2") {

			float random = Random.value;

			if (random > 0.66) {

				audioSource.PlayOneShot(hits[0]);

			} else if (random < 0.33) {

				audioSource.PlayOneShot(hits[1]);

			} else {

				audioSource.PlayOneShot(hits[2]);

			}

			Debug.Log ("Audio played");

		}

	}

}
