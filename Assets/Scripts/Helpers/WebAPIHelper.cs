using Assets.Scripts.Utils;
using CES2022_Server.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets.Scripts.Helpers
{
    public class WebAPIHelper
    {
        public delegate void ReceiveEventHandler(object obj);
        public event ReceiveEventHandler ReceiveEventHandlerEvent;
        private static WebAPIHelper _instance { get; set; }
        public static WebAPIHelper Instance
        {
            get
            {
                return _instance ?? (_instance = new WebAPIHelper());
            }
        }

        public IEnumerator Get<T>(string uri, string prameter = "")
        {
            using (UnityWebRequest request = UnityWebRequest.Get($"{SettingsInfo.WEBSERVICE_HOST}/{uri}/{prameter}"))
            {
                yield return request.SendWebRequest();
                try
                {
                    var jsonString = request.downloadHandler.text;
                    var dataObj = JsonConvert.DeserializeObject<T>(jsonString);
                    //이벤트로 데이터를 보낸다.
                    ReceiveEventHandlerEvent(dataObj);
                }
                catch (Exception e)
                {

                }
            }
        }

        public IEnumerator Post(string uri, WWWForm parameter)
        {
            using (UnityWebRequest request = UnityWebRequest.Post($"{SettingsInfo.WEBSERVICE_HOST}/{uri}", parameter))
            {
                yield return request.SendWebRequest();
                Debug.Log(request.result);
            }
        }

        public WWWForm Parameter_beacon(string name, string rssi, string range, string position)
        {
            WWWForm form = new WWWForm();
            form.AddField("code", CommonUtils.GenerateID());
            form.AddField("name", name);
            form.AddField("position", position);
            form.AddField("rssi", rssi);
            form.AddField("range", range);
           return form;
        }

        public WWWForm Parameter_user(string name, string nickName)
        {
            WWWForm form = new WWWForm();
            form.AddField("code", CommonUtils.GenerateID());
            form.AddField("name", name);
            form.AddField("nickName", nickName);
            return form;
        }

        public WWWForm Parameter_point(string point, string userCode, string itemCode)
        {
            WWWForm form = new WWWForm();
            form.AddField("userCode", userCode);
            form.AddField("point", point);
            form.AddField("itemCode", itemCode);
            return form;
        }
    }
}
