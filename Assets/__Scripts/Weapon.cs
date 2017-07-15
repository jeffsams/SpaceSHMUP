using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    none,
    blaster,
    spread,
    phaser,
    missle,
    laser,
    shield
}
[System.Serializable]
public class WeaponDefinition
{
    public WeaponType type = WeaponType.none;
    public string letter;
    public Color color = Color.white;
    public GameObject projectilePrefab;
    public Color projectileColor = Color.white;
    public float damageOnHit = 0;
    public float continuousDamage = 0;
    public float delayBetweenShots = 0;
    public float velocity = 20;
}

<<<<<<< HEAD
public class Weapon : MonoBehaviour
{
=======
public class Weapon : MonoBehaviour {
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
    static public Transform PROJECTILE_ANCHOR;

    public bool ______;
    [SerializeField]
    private WeaponType _type = WeaponType.none;
    public WeaponDefinition def;
    public GameObject collar;
    public float lastShot;
<<<<<<< HEAD

=======
    
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
    void Awake()
    {
        collar = transform.Find("Collar").gameObject;
    }
<<<<<<< HEAD
    // Use this for initialization
    void Start()
    {

=======
	// Use this for initialization
	void Start () {
      
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
        SetType(_type);

        if (PROJECTILE_ANCHOR == null)
        {
            GameObject go = new GameObject("_Projectile_Anchor");
            PROJECTILE_ANCHOR = go.transform;
        }
        GameObject parentGO = transform.parent.gameObject;
        if (parentGO.tag == "hero")
        {
            Hero.S.fireDelegate += Fire;
        }
<<<<<<< HEAD
    }
=======
	}
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582

    public WeaponType type
    {
        get { return (_type); }
<<<<<<< HEAD
        set { SetType(value); }
    }

    public void SetType(WeaponType wt)
=======
        set { SetType(value);  }
    }

    public void SetType (WeaponType wt)
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
    {
        _type = wt;
        if (type == WeaponType.none)
        {
            this.gameObject.SetActive(false);
            return;
<<<<<<< HEAD
        }
        else
=======
        } else
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
        {
            this.gameObject.SetActive(true);
        }
        def = Main.GetWeaponDefinition(_type);
        collar.GetComponent<Renderer>().material.color = def.color;
        lastShot = 0;
    }
<<<<<<< HEAD

=======
	
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
    public void Fire()
    {
        if (!gameObject.activeInHierarchy) return;
        if (Time.time - lastShot < def.delayBetweenShots)
        {
            return;
        }
        Projectile p;
        switch (type)
        {
            case WeaponType.blaster:
                p = MakeProjectile();
                p.GetComponent<Rigidbody>().velocity = Vector3.up * def.velocity;
                break;

            case WeaponType.spread:
                p = MakeProjectile();
                p.GetComponent<Rigidbody>().velocity = Vector3.up * def.velocity;
                p = MakeProjectile();
                p.GetComponent<Rigidbody>().velocity = new Vector3(-2f, 0.9f, 0) * def.velocity;
                p = MakeProjectile();
                p.GetComponent<Rigidbody>().velocity = new Vector3(2f, 0.9f, 0) * def.velocity;
                break;
        }
    }

    public Projectile MakeProjectile()
    {
        GameObject go = Instantiate(def.projectilePrefab) as GameObject;
        if (transform.parent.gameObject.tag == "Hero")
        {
            go.tag = "ProjectileHero";
            go.layer = LayerMask.NameToLayer("ProjectileHero");
        }
        else
        {
            go.tag = "ProjectileEnemy";
            go.layer = LayerMask.NameToLayer("ProjectileEnemy");
        }
        go.transform.position = collar.transform.position;
        go.transform.parent = PROJECTILE_ANCHOR;
        Projectile p = go.GetComponent<Projectile>();
        p.type = type;
        lastShot = Time.time;
        return (p);
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
