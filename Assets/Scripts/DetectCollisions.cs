using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameObject player;
    private PlayerController pc;
    [SerializeField] int point;


    private void OnTriggerEnter(Collider other) {

        player = GameObject.Find("Player");//�v���C���[��������
        pc = player.GetComponent<PlayerController>();//PlayerController��ۑ�
        pc.SetCountText(point);//Player�ɃX�R�A�X�V���˗�



      �@Destroy(gameObject);//�A�^�b�`����Ă��鎩�����g������
        Destroy(other.gameObject);//�Ԃ���������iother�j������
    }
}
