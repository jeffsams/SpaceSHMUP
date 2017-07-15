using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class PowerUp : MonoBehaviour
{
=======
public class PowerUp : MonoBehaviour {
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
    public Vector2 rotMinMax = new Vector2(15, 90);
    public Vector2 driftMinMax = new Vector2(.25f, 2);
    public float lifeTime = 6f;
    public float fadeTime = 4f;
    public bool _________;
    public WeaponType type;
    public GameObject cube;
    public TextMesh letter;
    public Vector3 rotPerSecond;
    public float birthTime;

    void Awake()
    {
        cube = transform.Find("Cube").gameObject;
        letter = GetComponent<TextMesh>();

        Vector3 vel = Random.onUnitSphere;
        vel.z = 0;
        vel.Normalize();
        vel *= Random.Range(driftMinMax.x, driftMinMax.y);
        GetComponent<Rigidbody>().velocity = vel;
        transform.rotation = Quaternion.identity;

        rotPerSecond = new Vector3(Random.Range(rotMinMax.x, rotMinMax.y),
                                    Random.Range(rotMinMax.x, rotMinMax.y),
                                    Random.Range(rotMinMax.x, rotMinMax.y));
        InvokeRepeating("CheckOffscreen", 2f, 2f);

        birthTime = Time.time;
    }
    // Use this for initialization
<<<<<<< HEAD
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
=======
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
        cube.transform.rotation = Quaternion.Euler(rotPerSecond * Time.time);
        float u = (Time.time - (birthTime + lifeTime)) / fadeTime;
        if (u >= 1)
        {
            Destroy(this.gameObject);
            return;
        }
<<<<<<< HEAD
        if (u > 0)
        {
=======
        if (u > 0) {
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
            Color c = cube.GetComponent<Renderer>().material.color;
            c.a = 1f - u;
            cube.GetComponent<Renderer>().material.color = c;
            c = letter.color;
            c.a = 1f - (u * 0.5f);
            letter.color = c;
        }

<<<<<<< HEAD
    }
=======
	}
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582

    public void AbsorbedBy(GameObject target)
    {
        Destroy(this.gameObject);
    }

    public void SetType(WeaponType wt)
    {
        WeaponDefinition def = Main.GetWeaponDefinition(wt);
        cube.GetComponent<Renderer>().material.color = def.color;
        letter.text = def.letter;
        type = wt;
    }
}
