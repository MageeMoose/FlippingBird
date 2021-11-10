using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    [SerializeField] GameObject cliffs;

    int score = 0;

    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 1.5f);    
    }

    void OnGUI() 
    {
        GUI.color = Color.black;
        GUILayout.Label(" Score: " + score.ToString());    
    }

    void CreateObstacle()
    {
        Instantiate(cliffs);
        score++;
    }

}
