using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    private float moveSpeed = 5;
    private Vector3 playerMove;
    

    void Update()
    {
        PlayerControl();

    }
    public void PlayerControl()
    {

        Vector3 offset = Vector3.zero;

        bool isHoldingUp = Input.GetKey(KeyCode.UpArrow);
        bool isHoldingDown = Input.GetKey(KeyCode.DownArrow);

        if (isHoldingUp)
            offset.y += moveSpeed;

        if (isHoldingDown)
            offset.y -= moveSpeed;

        transform.position += offset * Time.deltaTime;

    }
    

}