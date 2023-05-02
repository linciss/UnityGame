
using UnityEngine;
using UnityEngine.UI;

public class TextField : MonoBehaviour {

	public GameObject nameField;
	public GameObject ageField;
	public GameObject textField;

	public void showText()
	{
		
        textField.GetComponent<Text>().text = "Name: " + nameField.GetComponent<InputField>().text + "\nAge:" + ageField.GetComponent<InputField>().text;
    }
}
