﻿using UnityEngine;
using System.Collections;

public class GoldTotal : MonoBehaviour {

	public GUIStyle style1;
	public GameState gameState;

	void OnGUI() {
		GUI.Button(new Rect(120, 10, 100, 20), gameState.PlayerGold.ToString());
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
