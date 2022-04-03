using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_demoChar_ACmanager : MonoBehaviour
{
    public Animator[] AC_collection;

    public string param_A_name = "isWalking";
    public bool param_A_value = false;

    public string param_B_name = "isRunning";
    public bool param_B_value = false;

    public string param_C_name = "isJumping";
    public bool param_C_value = false;

    public string param_D_name = "isAlerted";
    public bool param_D_value = false;

    public string param_E_name = "isInteracting";
    public bool param_E_value = false;

    public string param_F_name = "isDefending";
    public bool param_F_value = false;

    public string param_G_name = "isHit";
    public bool param_G_value = false;

    public string param_H_name = "isDying";
    public bool param_H_value = false;

    public string param_I_name = "isTaunting";
    public bool param_I_value = false;

    public string param_J_name = "isKicking";
    public bool param_J_value = false;

    public string param_K_name = "isAttacking";
    public bool param_K_value = false;

    //-----------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        if(AC_collection.Length == 0)
        {
            Debug.Log("INFO: The anim controller list is empty...");
        }
    }

    //-----------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        for (int i = 0; i < AC_collection.Length; i++)
        {
            AC_collection[i].SetBool(param_A_name, param_A_value);
            AC_collection[i].SetBool(param_B_name, param_B_value);
            AC_collection[i].SetBool(param_C_name, param_C_value);
            AC_collection[i].SetBool(param_D_name, param_D_value);
            AC_collection[i].SetBool(param_E_name, param_E_value);
            AC_collection[i].SetBool(param_F_name, param_F_value);
            AC_collection[i].SetBool(param_G_name, param_G_value);
            AC_collection[i].SetBool(param_H_name, param_H_value);
            AC_collection[i].SetBool(param_I_name, param_I_value);
            AC_collection[i].SetBool(param_J_name, param_J_value);
            AC_collection[i].SetBool(param_K_name, param_K_value);
        }
    }
}
