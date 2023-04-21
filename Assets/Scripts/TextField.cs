using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextField : MonoBehaviour {

	public GameObject nameField;
	public GameObject ageField;
	public GameObject textField;

	public void showText()
	{ 
		textField.GetComponent<Text>().text = nameField.GetComponent<InputField>().text + "\n" + ageField.GetComponent<InputField>().text;
    }
}
