﻿namespace jogajunto_frontend
{
    public sealed class AppSettings
    {
        public static string JogaJuntoApiUrl { get => "https://us-central1-joga-junto-app.cloudfunctions.net/"; }

        public static string JogaJuntoHome { get => $"{JogaJuntoApiUrl}api/home"; }

        public static string OffLineDataBaseName { get => "adimaxpro.db"; }
    }
}
