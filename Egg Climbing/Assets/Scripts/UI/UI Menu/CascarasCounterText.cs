using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CascarasCounterText : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Text>().text = PlayerPrefs.GetInt("cascaras").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
