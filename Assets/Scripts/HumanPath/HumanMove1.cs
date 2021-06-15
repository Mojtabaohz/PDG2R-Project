using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanMove1 : MonoBehaviour
{
    GameObject Human;
    GameObject[] Nodes;
    public int pathNumber;
    int currentNode;
    float movespeed;
    float turnspeed;

    void Start () 
    {
        switch(pathNumber)
        {
            case 1:
                Nodes = GameObject.FindGameObjectsWithTag("path1");
                break;
            case 2:
                Nodes = GameObject.FindGameObjectsWithTag("path2");
                break;
            case 3:
                Nodes = GameObject.FindGameObjectsWithTag("path3");
                break;
            case 4:
                Nodes = GameObject.FindGameObjectsWithTag("path4");
                break;
            case 5:
                Nodes = GameObject.FindGameObjectsWithTag("path5");
                break;
            case 6:
                Nodes = GameObject.FindGameObjectsWithTag("path6");
                break;
            case 7:
                Nodes = GameObject.FindGameObjectsWithTag("path7");
                break;
            case 8:
                Nodes = GameObject.FindGameObjectsWithTag("path8");
                break;
            case 9:
                Nodes = GameObject.FindGameObjectsWithTag("path9");
                break;
            case 10:
                Nodes = GameObject.FindGameObjectsWithTag("path10");
                break;         
        }
        Human = gameObject;
        currentNode = 0;
        transform.position = Nodes[currentNode].transform.position;
        movespeed = Random.Range(0.3f, 0.5f);
        turnspeed = 5.0f;
	}
	
	void Update () 
    {
       PatrolLoop();
	}

 
    public void PatrolLoop()
    {
        if(Nodes.Length == 0) return;
        if(Vector3.Distance(Nodes[currentNode].transform.position, Human.transform.position) < 0.2f)
        {
            currentNode++;
            if(currentNode >= Nodes.Length)
            {
                currentNode = 0;
            }
        }

        var direction = Nodes[currentNode].transform.position - Human.transform.position;
        Human.transform.rotation = Quaternion.Slerp(Human.transform.rotation, Quaternion.LookRotation(direction), turnspeed * Time.deltaTime);
        Human.transform.Translate(0,0,Time.deltaTime * movespeed);
    }
}
