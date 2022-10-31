using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_MV4 : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody characterRigidbody;

    void Start()
    {
        characterRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        // -1 ~ 1

        float fallSpeed = characterRigidbody.velocity.y; // �������� �ӵ� ����

        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity *= speed;
        velocity.y = fallSpeed; // �������� �ӵ� �ʱ�ȭ
        characterRigidbody.velocity = velocity;
    }
}