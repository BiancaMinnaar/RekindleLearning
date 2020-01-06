using RekindleLearing.Root.ViewModel;
using Xamarin.Forms;

namespace RekindleLearing.Interface.Repository
{
    public interface IMasterRepository
    {
        MasterModel DataSource { get; set; }
        void ShowLoading();
        void HideLoading();
        void DumpJson<T>(string heading, T objectToDump);
        //#Bonsai Snippets - InterfaceMethods
    }
}