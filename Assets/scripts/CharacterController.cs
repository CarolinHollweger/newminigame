﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    private const string AXISHORIZONTAL = "Horizontal";      //configruation parameters     public float moveSpeed = 8.0f;     public float xMin = 0.0f, xMax = 8.0f;      // Use this for initialization     void Start()     {      }      // Update is called once per frame     void Update()     {         Move();     }      private void Move()     {         var deltaX = Input.GetAxis(AXISHORIZONTAL) * Time.deltaTime * moveSpeed;         var newPosX = Mathf.Clamp(transform.position.x + deltaX, xMin, xMax);          transform.position = new Vector2(newPosX, transform.position.y);     }
} 

