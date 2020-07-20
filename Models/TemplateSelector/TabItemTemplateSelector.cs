using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FullScratch.Models.TemplateSelector
{
    public class TabItemTemplateSelector:DataTemplateSelector
    {
        public DataTemplate TextBoxTabTemplate { get; set; }
        public DataTemplate GridViewTabTemplate { get; set; }
        public DataTemplate ImageTabTemplate { get; set; }

        public override DataTemplate SelectTemplate(object Item,DependencyObject container)
        {
            switch(((TabItem)Item).TabType)
            {
                case TabItem.ControlType.Text:
                    return TextBoxTabTemplate;

                case TabItem.ControlType.CSV:
                    return GridViewTabTemplate;

                case TabItem.ControlType.Image:
                    return ImageTabTemplate;

                default:
                    return TextBoxTabTemplate;
            }
        }
    }
}
