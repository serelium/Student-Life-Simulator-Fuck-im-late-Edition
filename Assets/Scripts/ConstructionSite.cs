﻿using UnityEngine;
using System.Collections;

public class ConstructionSite : MonoBehaviour {

    public int damage;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        Health health = collider.gameObject.GetComponent<Health>();

        if (health != null)
            health.TakeDamage(damage);
    }
}
