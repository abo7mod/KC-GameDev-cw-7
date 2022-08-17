using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{

    public float  minPos;
    public float  maxPos;

    public AudioSource src;

    public float inc;

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Enemy")
        {
            src.Play();
            Invoke("Restart", 1f);
        }
    }


    void Start()
    {
        src = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    void move()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {

            transform.position = new Vector3(Mathf.Clamp( transform.position.x - inc, maxPos, minPos), transform.position.y, transform.position.z);



        }
        else if (Input.GetKeyDown(KeyCode.D))
        {

         transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, maxPos, minPos), transform.position.y, transform.position.z);



        }



    }
    void Restart()
    {
        SceneManager.LoadScene(0);
        src.Play();



    }

}
