using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Week07 : MonoBehaviour
{
    [SerializeField] TMP_InputField num1;
    [SerializeField] TMP_InputField num2;
    [SerializeField] TMP_InputField num3;
    [SerializeField] TMP_InputField num4;
    [SerializeField] TMP_InputField num5;

    int x = 5; // Stack value variable.
    int[] myArray; // Stack reference variable.
    const int ISIZE = 5;

    [SerializeField]
    [Range(0, 100)]
    private int iSize;

    void Start()
    {
        myArray = new int[iSize]; // Dynamic memory allocation.
        // Load the array.
        for (int i = 0; i < iSize; i++)
        {
            myArray[i] = Random.Range(1, 101); // myArray[0], myArray[1], myArray[2]...
        }
        // Print the array.
        for (int i = 0; i < iSize; i++)
        {
            Debug.Log(myArray[i]);
        }
    }

    public void First()
    { // Convert strings to ints and put into array elements.
        Debug.Log("Now the First function!");
        int.TryParse(num1.text, out myArray[0]);
        int.TryParse(num2.text, out myArray[1]);
        int.TryParse(num3.text, out myArray[2]);
        int.TryParse(num4.text, out myArray[3]);
        int.TryParse(num5.text, out myArray[4]);
        // Print the array.
        for (int i = 0; i < iSize; i++)
        {
            Debug.Log(myArray[i]);
        }
    }

    public void Second()
    {
        Debug.Log("Now the Second function!");
        // In C++ we would have to say: delete [] myArray;
        myArray = System.Array.ConvertAll(num1.text.Split(' '), int.Parse);
        for (int i = 0; i < myArray.Length; i++)
        {
            Debug.Log(myArray[i]);
        }
    }
}
