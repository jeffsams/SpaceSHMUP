using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour
{

    public float rotationsPerSecond = 0.1f;
    public bool ___________________________;
    public int levelShown = 0;


    // Use this for initialization
    void Start()
    {

<<<<<<< HEAD
    }
=======
	}
	
	// Update is called once per frame
	void Update () {
		int currlevel = Mathf.FloorToInt (Hero.S.shieldLevel);
		if (levelShown != currlevel) {
			levelShown = currlevel;
            Material mat = this.GetComponent<Renderer>().material;
            mat.mainTextureOffset = new Vector2(0.2f*levelShown, 0f);
		}
>>>>>>> 311ac68533116b6b3e9a1bb8e46c90121b41a582

    // Update is called once per frame
    void Update()
    {
        int currlevel = Mathf.FloorToInt(Hero.S.shieldLevel);
        if (levelShown != currlevel)
        {
            levelShown = currlevel;
            Material mat = this.GetComponent<Renderer>().material;
            mat.mainTextureOffset = new Vector2(0.2f * levelShown, 0f);
        }

        float rZ = (rotationsPerSecond * Time.time * 360) % 360f;
        transform.rotation = Quaternion.Euler(0, 0, rZ);

    }
}