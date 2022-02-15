﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tarea3Movil.Models;
using System.IO;

namespace Tarea3Movil
{
    public partial class App : Application
    {
        static EmpleDB basedatos;

        public static EmpleDB BaseDatos
        {
            get
            {
                if (basedatos == null)
                {
                    basedatos = new EmpleDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EmpleDB.db3"));
                }
                return basedatos;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
