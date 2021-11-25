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
    /// 비콘 모든 목록을 가져옴
    /// </summary>
    void GetData_Beacons()
    {
        StartCoroutine(WebAPIHelper.Instance.Get<List<tb_beacon>>(SettingsInfo.API_BEACON));
    }

    void GetData_ZoneSchedule()
    {
        StartCoroutine(WebAPIHelper.Instance.Get<List<tb_zone_schedule>>(SettingsInfo.API_ZONE_SCHEDULE,"2"));
    }

    //스코어 0:전체 id:각 아이디에 맞는 스코어
    void GetData_Score()
    {
        StartCoroutine(WebAPIHelper.Instance.Get<tb_point>(SettingsInfo.API_SCORE, "74b8e274-097a-466b-b765-d4cb3ee164bd"));
    }

    //각 포인트 목록 산출
    void GetData_Point()
    {
        StartCoroutine(WebAPIHelper.Instance.Get<tb_point>(SettingsInfo.API_POINT));
    }

    //지정된 사용자 포인트 목록
    void GetData_PointWithParam()
    {
        StartCoroutine(WebAPIHelper.Instance.Get<tb_point>(SettingsInfo.API_POINT, "74b8e274-097a-466b-b765-d4cb3ee164bd"));
    }

    /// <summary>
    /// 포인트 추가
    /// </summary>
    /// <param name="point">스코어에 사용될 포인트</param>
    /// <param name="userCode">사용자 고유 코드</param>
    /// <param name="itemCode">아이템 고유 코드</param>
    void PostData_Point(string point, string userCode, string itemCode)
    {
        var param = WebAPIHelper.Instance.Parameter_point(point, userCode, itemCode);
        StartCoroutine(WebAPIHelper.Instance.Post(SettingsInfo.API_POINT, param));
    }
}
