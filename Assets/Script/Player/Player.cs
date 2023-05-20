using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public PlayerMovement playerMovement = new PlayerMovement();
    private Rigidbody2D rb;

    void Start(){
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update(){
        playerMovement.Moovement(rb);
    }
}
