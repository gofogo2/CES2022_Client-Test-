using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES2022_Server.Helpers
{
    public static class SettingsInfo
    {
        public static string WEBSERVICE_HOST = "http://127.0.0.1:3000";
        public static string SERVER_HOST = "127.0.0.1";
        public static string SERVER_BROADCAST = "255.255.255.255";
        public static int RECEIVER_PORT = 3333;
        public static int SENDER_PORT = 3334;
        public static readonly string API_BEACON = "beacon";
        public static readonly string API_ITEM = "item";
        public static readonly string API_USER = "user";
        public static readonly string API_POINT = "point";
        public static readonly string API_SCORE = "point/score";
        public static readonly string API_BUDDY = "buddy";
        public static readonly string API_BUDDY_LOCATION = "buddylocation";
        public static readonly string API_ZONE = "zone";
        public static readonly string API_ZONE_SCHEDULE = "zoneschedule";
    }
}
