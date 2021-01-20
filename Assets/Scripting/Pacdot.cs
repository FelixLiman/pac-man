using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pacdot : MonoBehaviour
{ 
    public TextMeshProUGUI scoreLbl;
    // private int score;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D co) {
        if (co.name == "pacman") {
            int myInt;
            int.TryParse(scoreLbl.text, out myInt);
            myInt++;
            Debug.Log(myInt);
            string newString = myInt.ToString();
            scoreLbl.text = newString;
            Destroy(gameObject);
        }
    }
}
