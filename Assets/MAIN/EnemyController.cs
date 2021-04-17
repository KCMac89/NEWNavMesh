using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


public class EnemyController : MonoBehaviour
{

    public NavMeshAgent enemyAgent;
    public GameObject player;

    void Start()
    {
        enemyAgent.updateRotation = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

   
    void Update()
    {
        enemyAgent.SetDestination(player.transform.position);

        if (GameManager.health < 1  )
        {
            SceneManager.LoadScene("Credits");
        }
        else if (GameManager.score >= GameManager.maxScore)
        {
            SceneManager.LoadScene("Credits");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject == player)
        {
            Debug.Log("Collided with: " + other.name);
            GameManager.health -= 1;

        }
    }
}
