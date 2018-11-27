using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    private float healthAmount = 100f;

    public void loseHealth(float amountToLose)
    {
        if (amountToLose < 100f)
            healthAmount -= amountToLose;

        Debug.Log(healthAmount);
    }

}
