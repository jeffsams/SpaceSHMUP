﻿using UnityEngine;
using System.Collections;
// Enemy_3 extends Enemy
public class Enemy_3 : Enemy
{
    // Enemy_3 will move following a Bezier curve, which is a linear

    //   interpolation between more than two points.
    public Vector3[] points;
    public float birthTime;
    public float lifeTime = 10;
<<<<<<< HEAD

    void Start()
    {
        points = new Vector3[3];
        points[0] = pos;

        float xMin = Utils.camBounds.min.x + Main.S.enemySpawnPadding;
        float xMax = Utils.camBounds.max.x - Main.S.enemySpawnPadding;
        Vector3 v;

=======
    
    void Start()
    {
        points = new Vector3[3]; 
        points[0] = pos;
    
        float xMin = Utils.camBounds.min.x + Main.S.enemySpawnPadding;
        float xMax = Utils.camBounds.max.x - Main.S.enemySpawnPadding;
        Vector3 v;
  
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
        v = Vector3.zero;
        v.x = Random.Range(xMin, xMax);
        v.y = Random.Range(Utils.camBounds.min.y, 0);
        points[1] = v;
<<<<<<< HEAD

=======
 
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
        v = Vector3.zero;
        v.y = pos.y;
        v.x = Random.Range(xMin, xMax);
        points[2] = v;
<<<<<<< HEAD

=======
   
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
        birthTime = Time.time;
    }
    // Update is called once per frame
    void Update()
    {

    }
    public override void Move()
    {
<<<<<<< HEAD

        float u = (Time.time - birthTime) / lifeTime;
        if (u > 1)
        {

            Destroy(this.gameObject);
            return;
        }

=======
      
        float u = (Time.time - birthTime) / lifeTime;
        if (u > 1)
        {
         
            Destroy(this.gameObject);
            return;
        }
      
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
        Vector3 p01, p12;
        u = u - 0.2f * Mathf.Sin(u * Mathf.PI * 2);
        p01 = (1 - u) * points[0] + u * points[1];
        p12 = (1 - u) * points[1] + u * points[2];
        pos = (1 - u) * p01 + u * p12;
    }
}

<<<<<<< HEAD
=======

>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
