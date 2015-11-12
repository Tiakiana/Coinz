using UnityEngine;
using System.Collections;

public class Townie : MonoBehaviour
{
    NavMeshAgent nma;

    public int team;
    public int gold;
    public float werf;
    public float sight;
    void Start()
    {
        nma = GetComponent<NavMeshAgent>();
    }
    void ChangeColor()
    {
        switch (team)
        {
            case 2:
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                break;

            case 3:
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 4:
                gameObject.GetComponent<Renderer>().material.color = Color.black;
                break;
            case 5:
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                break;
            case 6:
                gameObject.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 7:
                gameObject.GetComponent<Renderer>().material.color = Color.grey;
                break;
            case 8:
                gameObject.GetComponent<Renderer>().material.color = Color.cyan;
                break;
            case 9:
                gameObject.GetComponent<Renderer>().material.color = Color.magenta;
                break;
            case 10:
                gameObject.GetComponent<Renderer>().material.color = Color.clear;
                break;

            default:
                break;
        }

    }
   
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Gold")
        {
            if (team == 0 && col.gameObject.GetComponent<Gold>().team == 1)
            {
                team = Random.Range(2, 10);
                Debug.Log("" + team);
               // TakeOnRole();
                gold++;
                ChangeColor();
            }

            if (team == 0 && col.gameObject.GetComponent<Gold>().team != 1)
            {
                team = col.gameObject.GetComponent<Gold>().team;
                ChangeColor();
                gold++;
            }
            else
            {
                gold++;
            }

            
        }
    }

 

    void Update()
    {

    }
}
