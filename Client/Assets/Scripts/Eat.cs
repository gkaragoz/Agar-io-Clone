using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eat : MonoBehaviour {

    public string Tag;
    public Text Letters;
    public float Increase;

    int Score = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == Tag)
        {
            transform.localScale += new Vector3(Increase, Increase, Increase);
            Destroy(other.gameObject);

            Score += 10;
            Letters.text = "SCORE: " + Score;
        }
    }
}
