using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spown : MonoBehaviour
{
    public GameObject Enemy;
    public float delay;


    public Transform LeftPos;
    public Transform RightPos;
    public Transform MidPos;



    


    void Start()
    {
        InvokeRepeating("spown", 0f, delay);
    }

    void Update()
    {
        
    }
    void spown()
    {
        int randomPos = Random.Range(1, 4);

        if (randomPos == 1)
        {
            Instantiate(Enemy, LeftPos);


        }
        else if (randomPos == 2)
        {
            Instantiate(Enemy, RightPos);

        }
        else
        {
            Instantiate(Enemy, MidPos);

        }
       

        



    }
    void Restart()
    {
        SceneManager.LoadScene(0);

    }

}
