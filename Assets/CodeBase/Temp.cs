using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour
{
    
    void Start()
    {
        for(int i = 0;i <= 20; i += 2) // для і від одиниці до 20 з кроком 2
        {
                Debug.Log(i);// вивести в консоль і
        }   
        Debug.Log("Destroy after 4 seconds");
        Destroy(gameObject, 4f); // знищити  данний об'єкт через 4 секунди
    }

    void Update()
    {
        
    }
}
