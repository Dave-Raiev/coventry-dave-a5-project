using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField] private float initialSpeed = 10;
    [SerializeField] private float speedIncrease = 0.25f;
    private Vector3 ballPosition;
    
    void Start()
    {

    }
    private void Update()
    {
        bool startGame = Input.GetKey(KeyCode.Space);
        if (startGame)
        {
            ballPosition.x += (0+initialSpeed);
        }
    }
}
