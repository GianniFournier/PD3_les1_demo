using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;


public class CharacterControllerBehaviour : MonoBehaviour {


    private CharacterController _characterController;

	void Start () {

        _characterController = GetComponent<CharacterController>();


#if DEBUG

        if (_characterController == null)
            Debug.Log("ERROR: _characterController needs a component! (is null)");

        Assert.IsNotNull(_characterController, "ERROR: _characterController needs a component! (is null)");

#endif

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
