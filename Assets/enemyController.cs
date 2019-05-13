using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
	public Transform target;
	public float speed = 0.001f;
	private Vector3 vec;

	// Use this for initialization
	void Start ()
	{
		//target = GameObject.Find("対象").transform;
	}

	// Update is called once per frame
	void Update ()
	{
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (target.position - transform.position), 0.05f);
		transform.position += transform.forward * speed;

		// 当たり判定
		Vector2 p1=transform.position;
		Vector2 p2 = this.target.transform.position;
		Vector2 dir = p1 - p2;
		float d = dir.magnitude;
		float r1 = 0.8f;
		float r2 = 0.8f;

		if(d<r1+r2){
			Debug.Log ("当たった");
		}

	}
}
