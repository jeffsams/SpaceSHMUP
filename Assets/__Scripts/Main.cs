using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class Main : MonoBehaviour
{
=======
public class Main : MonoBehaviour {
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
    static public Main S;
    static public Dictionary<WeaponType, WeaponDefinition> W_DEFS;
    public GameObject[] prefabEnemies;
    public float enemySpawnPerSecond = .5f;
    public float enemySpawnPadding = 1.5f;
    public WeaponDefinition[] weaponDefinitions;
    public bool __________;
    public WeaponType[] activeWeaponTypes;
    public GameObject prefabPowerUp;
    public WeaponType[] powerUpFrequency = new WeaponType[]
    {
        WeaponType.blaster, WeaponType.blaster,
        WeaponType.spread,
        WeaponType.shield
    };

    public void ShipDestroyed(Enemy e)
    {
        if (Random.value <= e.powerUpDropChance)
        {
            int ndx = Random.Range(0, powerUpFrequency.Length);
            WeaponType puType = powerUpFrequency[ndx];

            GameObject go = Instantiate(prefabPowerUp) as GameObject;
            PowerUp pu = go.GetComponent<PowerUp>();
            pu.SetType(puType);
            pu.transform.position = e.transform.position;
        }
    }
    public float enemySpawnRate;

    void Awake()
    {
        S = this;
        Utils.SetCameraBounds(GetComponent<Camera>());
        enemySpawnRate = 1f / enemySpawnPerSecond;
        Invoke("SpawnEnemy", enemySpawnRate);

        W_DEFS = new Dictionary<WeaponType, WeaponDefinition>();
        foreach (WeaponDefinition def in weaponDefinitions)
        {
            W_DEFS[def.type] = def;
        }
    }

    static public WeaponDefinition GetWeaponDefinition(WeaponType wt)
    {
        if (W_DEFS.ContainsKey(wt))
        {
            return (W_DEFS[wt]);
        }
        return (new WeaponDefinition());
    }

    public void SpawnEnemy()
    {
        int ndx = Random.Range(0, prefabEnemies.Length);
        GameObject go = Instantiate(prefabEnemies[ndx]) as GameObject;
        Vector3 pos = Vector3.zero;
        float xMin = Utils.camBounds.min.x + enemySpawnPadding;
        float xMax = Utils.camBounds.max.x - enemySpawnPadding;
        pos.x = Random.Range(xMin, xMax);
        pos.y = Utils.camBounds.max.y + enemySpawnPadding;
        go.transform.position = pos;
        Invoke("SpawnEnemy", enemySpawnRate);
    }

    public void DelayedRestart(float delay)
    {
        Invoke("Restart", delay);
    }

    public void Restart()
    {
        Application.LoadLevel("_Scene_0");
    }
<<<<<<< HEAD
    // Use this for initialization
    void Start()
    {
=======
	// Use this for initialization
	void Start () {
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
        activeWeaponTypes = new WeaponType[weaponDefinitions.Length];
        for (int i = 0; i < weaponDefinitions.Length; i++)
        {
            activeWeaponTypes[i] = weaponDefinitions[i].type;
        }
<<<<<<< HEAD
    }

    // Update is called once per frame
    void Update()
    {

    }
=======
	}
	
	// Update is called once per frame
	void Update () {
		
	}
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582
}
