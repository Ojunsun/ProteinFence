using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float haxis;
    float vaxis;
    public float speed = 7f;

    Vector3 moveVec;

    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        haxis = Input.GetAxisRaw("Horizontal");
        vaxis = Input.GetAxisRaw("Vertical");

        moveVec = new Vector3(haxis, 0, vaxis).normalized;

        transform.position += moveVec * speed * Time.deltaTime;

        anim.SetBool("isMove", moveVec != Vector3.zero);

        transform.LookAt(transform.position + moveVec);
    }
}
