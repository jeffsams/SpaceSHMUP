using UnityEngine;
using System.Collections;

<<<<<<< HEAD
public class Hero : MonoBehaviour
{
=======
public class Hero : MonoBehaviour {
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582

    static public Hero S;

    public float gameRestartDelay = 2f;
    public float speed = 30;
    public float rollMult = -45;
    public float pitchMult = 30;
    [SerializeField]
    private float _shieldLevel = 1;

    public bool _____________________;
    public Bounds bounds;
    public delegate void WeaponFireDelegate();
    public WeaponFireDelegate fireDelegate;
    public Weapon[] weapons;

<<<<<<< HEAD
    void Awake()
    {
=======
    void Awake() {
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
        S = this;
        bounds = Utils.CombineBoundsOfChildren(this.gameObject);

    }


    // Use this for initialization
<<<<<<< HEAD
    void Start()
    {
=======
    void Start() {
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
        ClearWeapons();
        weapons[0].SetType(WeaponType.blaster);
    }

    // Update is called once per frame
<<<<<<< HEAD
    void Update()
    {
=======
    void Update() {
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        pos.x += xAxis * speed * Time.deltaTime;
        pos.y += yAxis * speed * Time.deltaTime;
        transform.position = pos;

        bounds.center = transform.position;

        // constrain to screen
        Vector3 off = Utils.ScreenBoundsCheck(bounds, BoundsTest.onScreen);
<<<<<<< HEAD
        if (off != Vector3.zero)
        {  // we need to move ship back on screen
=======
        if (off != Vector3.zero) {  // we need to move ship back on screen
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
            pos -= off;
            transform.position = pos;
        }

        // rotate the ship to make it feel more dynamic
        transform.rotation = Quaternion.Euler(yAxis * pitchMult, xAxis * rollMult, 0);

        if (Input.GetAxis("Jump") == 1 && fireDelegate != null)
        {
            fireDelegate();
        }

    }

    public GameObject lastTriggerGo = null;

    void OnTriggerEnter(Collider other)
    {
        GameObject go = Utils.FindTaggedParent(other.gameObject);
        if (go != null)
        {
            if (go == lastTriggerGo)
            {
                return;
            }
            lastTriggerGo = go;

            if (go.tag == "Enemy")
            {
                shieldLevel--;
                Destroy(go);
<<<<<<< HEAD
            }
            else if (go.tag == "PowerUp")
=======
            } else if (go.tag == "PowerUp")
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
            {
                AbsorbPowerUp(go);
            }
            else
            {
                print("Triggerred: " + go.name);
            }
        }
        else
        {
            print("Triggered: " + other.gameObject.name);
        }
    }

    public void AbsorbPowerUp(GameObject go)
    {
        PowerUp pu = go.GetComponent<PowerUp>();
<<<<<<< HEAD
        switch (pu.type)
=======
        switch(pu.type)
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
        {
            case WeaponType.shield:
                shieldLevel++;
                break;

            default:
                if (pu.type == weapons[0].type)
                {
                    Weapon w = GetEmptyWeaponSlot();
                    if (w != null)
                    {
                        w.SetType(pu.type);
                    }
                }
                else
                {
                    ClearWeapons();
                    weapons[0].SetType(pu.type);
                }
                break;
        }
        pu.AbsorbedBy(this.gameObject);
    }

    Weapon GetEmptyWeaponSlot()
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if (weapons[i].type == WeaponType.none)
            {
                return (weapons[i]);
            }
        }
        return (null);
    }

    void ClearWeapons()
    {
<<<<<<< HEAD
        foreach (Weapon w in weapons)
=======
        foreach(Weapon w in weapons)
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
        {
            w.SetType(WeaponType.none);
        }
    }
<<<<<<< HEAD
    public float shieldLevel
=======
        public float shieldLevel
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
    {
        get
        {
            return (_shieldLevel);
        }
        set
        {
            _shieldLevel = Mathf.Min(value, 4);
            if (value < 0)
            {
                Destroy(this.gameObject);
                Main.S.DelayedRestart(gameRestartDelay);
            }
        }
    }
<<<<<<< HEAD
}
=======
        }
    

    
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
