using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perspective : MonoBehaviour {
    
    [SerializeField] private GameObject stairs, bookshelf, wall;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.name == "KitchenTrigger") {
			stairs.transform.position = new Vector3(-3.56f, -2.24f, 5.0f);
		}
		if(other.name == "BookshelfTrigger") {
			bookshelf.SetActive(false);
			wall.SetActive(false);
		}
		
}
		void OnTriggerExit2D(Collider2D other) {
		if(other.name == "KitchenTrigger") {
			stairs.transform.position = new Vector3(-3.56f, -2.24f, -1.0f);
		}
		if(other.name == "BookshelfTrigger") {
			bookshelf.SetActive(true);
			wall.SetActive(true);
		}
}
    }

