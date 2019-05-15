using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FollowScript : MonoBehaviour
{
    [SerializeField] float m_moveSpeed = 1f;
    [SerializeField] Transform m_target;
    Rigidbody2D m_rb;

    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 dir = m_target.position - transform.position;
        dir.Normalize();
        m_rb.velocity = dir * m_moveSpeed;
    }
}
