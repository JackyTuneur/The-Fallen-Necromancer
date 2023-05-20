using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{

    private float tempSpeed = 10f;
    public Vector2 change = new Vector2(0f,0f);

    public void Moovement(Rigidbody2D playerRb){
        change.x = Input.GetAxis("Horizontal");
        change.y = Input.GetAxis("Vertical");

        if(change != Vector2.zero)
        {
            Vector2 currentPos = playerRb.position;
            Vector2 adjustedMovement = change * tempSpeed;
            Vector2 newPos = currentPos + adjustedMovement * Time.fixedDeltaTime;
            playerRb.MovePosition(newPos);
        }
    }
}
