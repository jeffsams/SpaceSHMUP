using UnityEngine;
using System.Collections;
// Enemy_1 extends the Enemy class
public class Enemy_1 : Enemy
{

    public float waveFrequency = 2;
<<<<<<< HEAD

    public float waveWidth = 4;
    public float waveRotY = 45;
    private float x0 = -12345;
=======
    
    public float waveWidth = 4;
    public float waveRotY = 45;
    private float x0 = -12345; 
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582

    private float birthTime;
    void Start()
    {
<<<<<<< HEAD

        x0 = pos.x;
        birthTime = Time.time;
    }

    public override void Move()
    {
        Vector3 tempPos = pos;

=======
 
        x0 = pos.x;
        birthTime = Time.time;
    }
  
    public override void Move()
    {                                         
        Vector3 tempPos = pos;
        
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
        float age = Time.time - birthTime;
        float theta = Mathf.PI * 2 * age / waveFrequency;
        float sin = Mathf.Sin(theta);
        tempPos.x = x0 + waveWidth * sin;
        pos = tempPos;
<<<<<<< HEAD

        Vector3 rot = new Vector3(0, sin * waveRotY, 0);
        this.transform.rotation = Quaternion.Euler(rot);

        base.Move();
=======
     
        Vector3 rot = new Vector3(0, sin * waveRotY, 0);
        this.transform.rotation = Quaternion.Euler(rot);
        
        base.Move();                                          
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
    }
}