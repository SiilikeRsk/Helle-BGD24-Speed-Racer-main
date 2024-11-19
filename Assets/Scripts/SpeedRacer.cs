using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public string carMaker;
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";

    public int carWeight = 1609;
    public int yearMade = 2009;

    public float maxAcceleration = 0.98f;

    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    public class Fuel
    {
        public int fuelLevel;

        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }
    public Fuel carFuel = new Fuel(100);




    void Start()
    {
        print("The car model is " + carModel + " by the company " + carMaker + " and the engine type is " + engineType);

        CheckWeight();

        if (yearMade <= 2009)
        {
            print(carModel + " was introduced in " + yearMade);

            int carAge = CalculateAge(yearMade);

            print("That means, the " + carModel + " is " + carAge + " years old.");
        }
        else
        {
            print("The car was made in the 2010's.");
            print("The " + carModel + "’s maximum acceleration is " + maxAcceleration + " m/s.");
        }

        print(CheckCharacteristics());
    }
    void CheckWeight()
    {
        if (carWeight <= 1500)
        {
            print(carModel + " weighs less than 1500 kg.");

        }
        else
        {
            print(carModel + " weighs over 1200 kg.");
        }
    }
    int CalculateAge(int yearMade)
    {
        return 2023 - yearMade;
    }

    string CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
            return "The car is a sedan.";

        }
        else if (hasFrontEngine)
        {
            return "The car is not a sedan, but it has a front engine.";

        }
        else
        {
            return "The car is neither a sedan, nor is the engine a front engine.";
        }

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }
        void ConsumeFuel()
        {
            carFuel.fuelLevel = carFuel.fuelLevel - 10;
        }
    }

    void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 70:
                print("Fuel level is nearing two-thirds.");
                break;
            case 50:
                print("Fuel level is at half amount.");
                break;
            case 10:
                print("Warning! Fuel level is critically low.");
                break;
            default:
                print("Nothing to report.");
                break;
        }
    }
}
    

