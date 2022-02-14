using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FibonacciSequence : MonoBehaviour
{
    private int firstNumber;
    private int secondNumber;
    private int currentElement;
    private int currentNumber;
    // Start is called before the first frame update
    void Start()
    {
        SetInitialNumbers();
    }

    // Provides the program numbers to start the fibonacci sequence with.
    private void SetInitialNumbers() {
        firstNumber = 0;
        secondNumber = 1;
        currentElement = 0;
    }

    // Returns the correct number of the fibonacci sequence.
    public void FibonacciFetch() {

        currentElement++;

        switch (currentElement)
        {
            //Case 1 and 2 are equal to the initial first and second numbers
            case 1: 
                currentNumber = 0;
                break;
            case 2:
                currentNumber = 1;
                break;
            default:
                currentNumber = FibonacciCalculate();
                break;
        }

        Debug.Log("Element: " + currentElement + ", number: " + currentNumber);
    }

    //Calculates the correct number in the fibonacci sequence, returns it as an int 
    private int FibonacciCalculate()
    {
        int nextNumber = firstNumber + secondNumber;

        SetNextNumbers(nextNumber);

        return nextNumber;
    }

    private void SetNextNumbers(int nextNumber)
    {
        firstNumber = secondNumber;
        secondNumber = nextNumber;
    }
}
