using UnityEngine;
using System.Collections;

public class Gold : MonoBehaviour {
    public int team = 1;
	void Start () {
	
	}

    public void SetTeam(int t)
    {
        team = t;

    }
	
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            DestroyObject(gameObject);
        }

    }

	void Update () {
	
	}
}
