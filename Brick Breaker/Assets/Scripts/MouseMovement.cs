using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour {

	void Update () {
        //get current player position
        Vector3 paddlePosition = new Vector3(0, gameObject.transform.position.y, 0);

        //get mouse x position
        float mousePositionInBlocks = Input.mousePosition.x / Screen.width * 16 - 8;

        paddlePosition.x = mousePositionInBlocks;
        
        //set player to saved posistion
        gameObject.transform.position = paddlePosition;
	}
}
