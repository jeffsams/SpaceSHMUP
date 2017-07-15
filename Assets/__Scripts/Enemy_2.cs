using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class Enemy_2 : Enemy
{
=======
public class Enemy_2 : Enemy {
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
    public Vector3[] points;
    public float birthTime;
    public float lifeTime = 10;
    public float sinEccentricity = 0.6f;
<<<<<<< HEAD
    // Use this for initialization
    void Start()
    {
=======
	// Use this for initialization
	void Start () {
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
        points = new Vector3[2];
        Vector3 cbMin = Utils.camBounds.min;
        Vector3 cbMax = Utils.camBounds.max;
        Vector3 v = Vector3.zero;

        v.x = cbMin.x - Main.S.enemySpawnPadding;
        v.y = Random.Range(cbMin.y, cbMax.y);
        points[0] = v;
        v = Vector3.zero;
        v.x = cbMax.x + Main.S.enemySpawnPadding;
        v.y = Random.Range(cbMin.y, cbMax.y);
        points[1] = v;
        if (Random.value < .5f)
        {
            points[0].x *= -1;
<<<<<<< HEAD
            points[1].x *= -1;
        }
        birthTime = Time.time;
    }

=======
            points[1].x *= -1; 
        }
        birthTime = Time.time;
	}
	
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
    public override void Move()
    {
        float u = (Time.time - birthTime) / lifeTime;
        if (u > 1)
        {
            Destroy(this.gameObject);
            return;
        }
        u = u + sinEccentricity * (Mathf.Sin(u * Mathf.PI * 2));
        pos = (1 - u) * points[0] + u * points[1];
    }

<<<<<<< HEAD

    // Update is called once per frame
    void Update()
    {

    }
=======
   
	// Update is called once per frame
	void Update () {
		
	}
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
}
