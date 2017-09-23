using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var rand = Random.Range(-0.3f, 0.3f);
		this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y, this.transform.position.z + rand);
	}
}
