﻿using KR2_Morozov.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KR2_Morozov
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static KR2_MorozovEntities DB = new KR2_MorozovEntities();

        public static User loginedUser;
    }
}
