using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class enemyController : MonoBehaviour
{
	[SerializeField] float moveSpeed = 1f;
	[SerializeField] Transform target;
	Rigidbody2D rb;

	// Use this for initialization
	void Start ()
	{
		//target = GameObject.Find("対象").transform;
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update ()
	{
		Vector2 dir = target.position - transform.position;
		dir.Normalize();
		rb.velocity = dir * moveSpeed;

		// 当たり判定
		Vector2 p1=transform.position;
		Vector2 p2 = this.target.transform.position;
		Vector2 dis = p1 - p2;
		float d = dis.magnitude;
		float r1 = 0.7f;
		float r2 = 0.7f;

		if(d<r1+r2){
			Debug.Log ("当たった");
		}

	}
}
