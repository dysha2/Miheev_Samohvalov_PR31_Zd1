﻿using BeatySalon.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BeatySalon.Selectors
{
    internal class MessageBoxSelector:DataTemplateSelector
    {
        public DataTemplate JustInfoTemplate { get; set; }
        public DataTemplate YesNoTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            switch ((MessageType)item)
            {
                    case MessageType.YesNo:return YesNoTemplate;
                default: return JustInfoTemplate;
            }
        }
    }
}
