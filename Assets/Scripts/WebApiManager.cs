using Assets.Scripts;
using CES2022_Server.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using Newtonsoft.Json;
using CES2022_Server.Helpers;
using Assets.Scripts.Converters;
using Assets.Scripts.Helpers;

public class WebApiManager : MonoBehaviour
{
    [SerializeField]
    Text text;
    void Start()
    {
        WebAPIHelper.Instance.ReceiveEventHandlerEvent += ReceiveEventHandlerEvent;
        PostData_Point("50", "74b8e274-097a-466b-b765-d4cb3ee164bd", "2");
    }

    private void ReceiveEventHandlerEvent(object obj)
    {

    }

    //User
    void GetData_Users() {
        StartCoroutine(WebAPIHelper.Instance.Get<tb_user>(SettingsInfo.API_USER, "74b8e274-097a-466b-b765-d4cb3ee164bd"));
    }

    void GetData_UserWithParameter()
    {
        StartCoroutine(WebAPIHelper.Instance.Get<tb_user>(SettingsInfo.API_USER, "74b8e274-097a-466b-b765-d4cb3ee164bd"));
    }

    void PostData_User()
    {
        var param = WebAPIHelper.Instance.Parameter_user("yoo","ancozy" );
        StartCoroutine(WebAPIHelper.Instance.Post(SettingsInfo.API_USER,param));
    }

    /// <summary>
    /// ���� ��� ����� ������
    /// </summary>
    void GetData_Beacons()
    {
        StartCoroutine(WebAPIHelper.Instance.Get<List<tb_beacon>>(SettingsInfo.API_BEACON));
    }

    void GetData_ZoneSchedule()
    {
        StartCoroutine(WebAPIHelper.Instance.Get<List<tb_zone_schedule>>(SettingsInfo.API_ZONE_SCHEDULE,"2"));
    }

    //���ھ� 0:��ü id:�� ���̵� �´� ���ھ�
    void GetData_Score()
    {
        StartCoroutine(WebAPIHelper.Instance.Get<tb_point>(SettingsInfo.API_SCORE, "74b8e274-097a-466b-b765-d4cb3ee164bd"));
    }

    //�� ����Ʈ ��� ����
    void GetData_Point()
    {
        StartCoroutine(WebAPIHelper.Instance.Get<tb_point>(SettingsInfo.API_POINT));
    }

    //������ ����� ����Ʈ ���
    void GetData_PointWithParam()
    {
        StartCoroutine(WebAPIHelper.Instance.Get<tb_point>(SettingsInfo.API_POINT, "74b8e274-097a-466b-b765-d4cb3ee164bd"));
    }

    /// <summary>
    /// ����Ʈ �߰�
    /// </summary>
    /// <param name="point">���ھ ���� ����Ʈ</param>
    /// <param name="userCode">����� ���� �ڵ�</param>
    /// <param name="itemCode">������ ���� �ڵ�</param>
    void PostData_Point(string point, string userCode, string itemCode)
    {
        var param = WebAPIHelper.Instance.Parameter_point(point, userCode, itemCode);
        StartCoroutine(WebAPIHelper.Instance.Post(SettingsInfo.API_POINT, param));
    }
}
