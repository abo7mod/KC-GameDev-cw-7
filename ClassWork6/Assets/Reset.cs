using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;





public class Reset : MonoBehaviour
{

    private int score;
    public Text text1;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);

    }
    IEnumerator Score1()
    {
        score++;
        yield return new WaitForSeconds(0.3f);
        text1.text = score.ToString();
        StartCoroutine(Score1());
        

    }
    private void Start()
    {
        StartCoroutine(Score1());


    }
}
