using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imageControl : MonoBehaviour
{
    [SerializeField] GameObject sumaho;
    private void Start()
    {
     
    }

    void Update()
    {
        //X�L�[������
        if (Input.GetKeyDown(KeyCode.X))
        {
            //�Q�[���I�u�W�F�N�g�\������\��
            sumaho.SetActive(false);
        }
        //Z�L�[������
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //�Q�[���I�u�W�F�N�g��\�����\��
            sumaho.SetActive(true);
        }
    }
}
