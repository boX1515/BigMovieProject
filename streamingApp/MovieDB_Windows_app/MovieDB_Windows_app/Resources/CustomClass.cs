﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MovieDB_Windows_app.API;

namespace MovieDB_Windows_app.Resources
{
    public class Movie
    {
        public class Data
        {
            public int Id { get; set; }
            public string name { get; set; }
            public string ext { get; set; }
            public string guid { get; set; }
            public string folder { get; set; }
            public string dir { get; set; }
            public Nullable<int> views { get; set; }
            public Nullable<System.DateTime> added { get; set; }
            public bool enabled { get; set; }
            public Info Movie_Info { get; set; }
        }
        public class Info
        {
            public int id { get; set; }
            public Nullable<bool> adult { get; set; }
            public string backdrop_path { get; set; }
            public string budget { get; set; }
            public string homepage { get; set; }
            public string imdb_id { get; set; }
            public string original_title { get; set; }
            public string overview { get; set; }
            public string popularity { get; set; }
            public string poster_path { get; set; }
            public string release_date { get; set; }
            public string revenue { get; set; }
            public string status { get; set; }
            public string tagline { get; set; }
            public string title { get; set; }
            public string vote_average { get; set; }
            public string vote_count { get; set; }
            public string genres { get; set; }
            public string production_countries { get; set; }
            public string production_companies { get; set; }
            public string spoken_languages { get; set; }
        }
    }
    
    public class User
    {
        public class Info
        {
            public int Id { get; set; }
            public string unique_id { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public string profile_image { get; set; }
            public string display_name { get; set; }
            public DateTime? profile_created { get; set; }
            public DateTime? last_logon { get; set; }
            public DateTime? birthday { get; set; }
            public string email { get; set; }
            public int group { get; set; }

        }
        public class Groups
        {
            public int Id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public string access { get; set; }
            public string desc { get; set; }
            public bool status { get; set; }
        }
    }

    public class APIObjects
    {
        /// <summary>
        /// Administration all data 
        /// </summary>
        public class Data
        {
            public Users users { get; set; }
            public List<Settings> disks { get; set; }
            public List<Movie.Data> movies { get; set; }
            public List<Settings> settings { get; set; }
            public List<History.API> apiHistory { get; set; }
        }

        /// <summary>
        /// Administration all users and groups object
        /// </summary>
        public class Users
        {
            public List<User.Groups> groups { get; set; }
            public List<User.Info> users { get; set; }
        }

        /// <summary>
        /// Disks init object
        /// </summary>
        public class Settings
        {
            public int id { get; set; }
            public string name { get; set; }
            public string value { get; set; }
        }

        /// <summary>
        /// Movie/user edit object
        /// </summary>
        public class Edit
        {
            public Data api { get; set; }
            public Movie.Data movie { get; set; }
            public User.Info user { get; set; }
            public User.Groups groups { get; set; }
            public Auth.User auth { get; set; }
        }
    }

    public class values
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class History
    {
        public class API
        {
            public int Id { get; set; }
            public Nullable<System.DateTime> api_datetime { get; set; }
            public string api_action { get; set; }
            public string api_type { get; set; }
        }

        public class User
        {
            public int Id { get; set; }
            public string user_id { get; set; }
            public string user_action { get; set; }
            public string user_type { get; set; }
            public string user_movie { get; set; }
            public Nullable<System.DateTime> user_datetime { get; set; }
        }
    }
}