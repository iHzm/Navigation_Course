﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerController : MonoBehaviour {

	public GameObject target;
	public NavMeshAgent agent;
	
	void Start () {
		agent = GetComponent<NavMeshAgent>();
	}
	

	void Update () {
		agent.SetDestination(target.transform.position);
	}
}
