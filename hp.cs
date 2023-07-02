using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hp : MonoBehaviour
{
    [SerializeField] private int Hp;
    [SerializeField] private Text hpT;
    [SerializeField] private int hpDmg;

    void Start()
    {
        hpT.text = "Жизни: " + Hp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Trap")
        {
            Hp = Hp - hpDmg;
            hpT.text = "Жизни: " + Hp.ToString();
            if (Hp <= 0)
            {
                Destroy(gameObject);
                hpT.text = "Жизни: 0";
            }
        }
    }
}
