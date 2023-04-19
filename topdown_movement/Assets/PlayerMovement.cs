using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rigidbody;

    [SerializeField]
    private Vector3 rotationVector;

    [SerializeField]
    private VariableJoystick joystick;

    [SerializeField]
    private float moveSpeed = 2;

    [SerializeField]
    private int health = 5;

    private bool isDead;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float horizontalAxis = joystick.Horizontal;
        float verticalAxis = joystick.Vertical;
        Vector3 moveVector = new Vector3(0, rigidbody.velocity.y, 0);
        rigidbody.velocity = transform.forward * moveSpeed + moveVector;
        Vector3 rotationVector = new Vector3(horizontalAxis, 0, verticalAxis);
        transform.LookAt(transform.position + rotationVector);
        if (Mathf.Abs(horizontalAxis) <= 0 && Mathf.Abs(verticalAxis) <= 0)
        {
            rigidbody.velocity = Vector3.zero;
        }
        if (health <= 0 && !isDead)
        {
            isDead = true;
            StartCoroutine(DeadRoutine());
        }
    }

    private IEnumerator DeadRoutine()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }

    public void TakeDamage()
    {
        health--;
    }

}
