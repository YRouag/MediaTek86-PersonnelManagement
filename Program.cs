﻿using System;
using System.Windows.Forms;
using MediaTek86.Views;

namespace MediaTek86
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); // Formulaire de démarrage
        }
    }
}
