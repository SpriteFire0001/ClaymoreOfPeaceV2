using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackRange : MonoBehaviour
{
    public Animator AttackAnim;
    public GameObject FoeAxe;

    private void Start()
    {
        FoeAxe.SetActive(false);
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Foe.FoeSpeed = 0f;
            AttackAnim.SetBool("FoeIsWalking", false);
            AttackAnim.SetBool("FoeAttacks", true);
            FoeAxe.SetActive(true);

        }       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FoeAxe.SetActive(false);
            AttackAnim.SetBool("FoeAttacks", false);
            AttackAnim.SetBool("FoeIsWalking", true);
            Foe.FoeSpeed = 2.5f;
        }
    }




}
