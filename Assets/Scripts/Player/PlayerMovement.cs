using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    public float sideMovementSpeed = 4;
    void Update()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.leftSide)
                return;

            this.transform.Translate(Vector3.left * Time.deltaTime * sideMovementSpeed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.rightSide)
                return;

            this.transform.Translate(Vector3.right * Time.deltaTime * sideMovementSpeed);
        }
    }
}
