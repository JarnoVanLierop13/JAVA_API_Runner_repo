using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

    private Player player;

	// Use this for initialization
	void Start () {
        player = gameObject.GetComponent<Player>();
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        player.grounded = true;
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        player.grounded = true;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        player.grounded = false;
    }
}
