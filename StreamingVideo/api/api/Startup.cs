﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Threading.Tasks;
using api.Resources;
using System.Threading;
using System.Diagnostics;

[assembly: OwinStartup(typeof(api.Startup))]

namespace api
{
    public partial class Startup
    {
        public async void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            await DatabaseMovieCheck();
        }

        public async Task DatabaseMovieCheck()
        {
            Thread t1;
            await Task.Delay(0);
            try
            {
                t1 = new Thread(async () => await Database.CheckDB())
                {
                    Priority = ThreadPriority.Normal
                };
                t1.Start();
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Exception : Startup.cs --> {0}", ex.Message);
            }
            
           
        }
    }
}
