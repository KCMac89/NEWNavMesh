using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAnimation : MonoBehaviour {

	public float speed = .2f;
	public float strength = 9f;

	private float randomOffset;

	public GameObject player;

	// Use this for initialization
	void Start () {
		randomOffset = Random.Range(0f, 2f);
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.x = Mathf.Sin(Time.time * speed + randomOffset) * strength;
		transform.position = pos;
	}


	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == player)
		{
			Debug.Log("Collided with: " + other.name);
			GameManager.health -= 1;

		}
	}
}
