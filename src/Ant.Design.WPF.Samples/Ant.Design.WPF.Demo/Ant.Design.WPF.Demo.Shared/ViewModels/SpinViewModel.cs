﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Text;
using Caliburn.Micro;

namespace AntdDemo.ViewModels
{
    [Export(typeof(IScreen))]
    internal class SpinViewModel : Screen
    {
        public SpinViewModel()
        {
            DisplayName = "Spin";
        }
    }
}
