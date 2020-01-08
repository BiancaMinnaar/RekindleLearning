using System;
using RekindleLearing.Trunk.View.Control;
using Xamarin.Forms;

namespace RekindleLearing.Trunk.View.TemplateSelector
{
    public class QuestionPadTemplateSelector : DataTemplateSelector
    {
        public DataTemplate questionCheckbox { get; set; }
        public DataTemplate questionRadioButton { get; set; }

        //public QuestionPadTemplateSelector()
        //{
        //    questionCheckbox = new DataTemplate(typeof(RadioButtonQuestionControlView));
        //}

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return questionCheckbox;
        }
    }
}
