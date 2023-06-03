using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boosters : MonoBehaviour
{
    private bool energy_drink;
    private bool oatmeal_dish;
    private bool juice_drink;

    private int energy_drink_counter;
    private int oatmeal_dish_counter;
    private int juice_drink_counter;

    // Update is called once per frame
    void Update()
    {

    }

    float CalculateEnergyCollected(int speed, float energy_collected_per_second)
    {
        return speed * energy_collected_per_second;
    }

    float CalculateSpeed(int current_speed, int booster_coefficient)
    {
        return current_speed * booster_coefficient;
    }

    void UpdateScore()
    {

    }

    

}
