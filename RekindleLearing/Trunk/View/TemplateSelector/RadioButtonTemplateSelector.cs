using System;
using RekindleLearing.Trunk.View.Control;
using Xamarin.Forms;

namespace RekindleLearing.Trunk.View.TemplateSelector
{
    public class RadioButtonTemplateSelector : DataTemplateSelector
    {
        public DataTemplate questionCheckbox { get; set; }

        //public RadioButtonTemplateSelector()
        //{
        //    questionCheckbox = new DataTemplate(typeof(RadioButtonQuestionControlView));
        //}

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return questionCheckbox;
        }
    }
}
