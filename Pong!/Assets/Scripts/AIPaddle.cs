using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    private Vector3 playerMove;
    [SerializeField] private GameObject ball;


    public void Update()
    {
        AIControl();

    }

    private void AIControl()
    {




        if (ball.transform.position.y < playerMove.y + 2.5f)
        {
            playerMove = new Vector3(0, 1, 0);
        }
        else if (ball.transform.position.y < transform.position.y + 2.5f)
        {
            playerMove = new Vector3(0, -1, 0);
        }
        else
        {
            playerMove = new Vector3(0, 0, 0);

        }
    }


}
