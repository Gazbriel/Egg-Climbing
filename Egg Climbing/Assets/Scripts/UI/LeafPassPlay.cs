using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafPassPlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("Big Leaf Right").GetComponent<Animator>().SetBool("out", true);
        GameObject.Find("Big Leaf Left").GetComponent<Animator>().SetBool("out", true);
        GameObject.Find("Big Leaf Up").GetComponent<Animator>().SetBool("out", true);
    }


    public float timeToEliminate;
	// Update is called once per frame
	void Update () {
        if (timeToEliminate < 0)
        {
            Destroy(this.gameObject);
        }
        else
        {
            timeToEliminate -= Time.deltaTime;
        }
	}
}
