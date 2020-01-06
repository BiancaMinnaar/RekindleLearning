using System.Threading.Tasks;
using RekindleLearing.Root.Repository;
using RekindleLearing.Trunk.ViewModel;
using RekindleLearing.Interface.Repository;
using RekindleLearing.Interface.Service;
using System;
using RekindleLearing.Trunk.ViewModel.Control;

namespace RekindleLearing.Implementation.Repository
{
    public class SystemRepository<T> : ProjectBaseRepository, ISystemRepository<T>
    {
        ISystemService<T> _Service;
        
        public SystemRepository(IMasterRepository masterRepository, ISystemService<T> service)
            : base(masterRepository)
        {
            _Service = service;
        }
        
       public async Task GetSystemInfoAsync(SystemViewModel model)
        {
            SetButtonControl("Imprint", "google.com", model.ImprintLinkButton);
            SetButtonControl("Terms And Conditions", "google.com", model.TermsAndConditonsLinkButton);
            SetButtonControl("Privacy Policy", "google.com", model.PrivacyPolicyLinkButton);
            SetButtonControl("EULA - ENd User License Agreement", "google.com", model.EULALinkButton);

            SetServerTile(model.ServerInfoTile);
            SetClientTile(model.ClientInfoTile);
        }

        private void SetClientTile(ClientInfoControlViewModel clientInfoTile)
        {
            clientInfoTile.Version = "5.0.10 (c761262)";
            clientInfoTile.Date= "20.12.2019 02:19";
            clientInfoTile.IOSVesrion = "13.3";
        }

        private void SetServerTile(ServerInfoControlViewModel serverInfoTile)
        {
            serverInfoTile.Version = "5.7.2-final";
            serverInfoTile.Date = "1019-1-17 22:38:42.313+0100";
            serverInfoTile.Build = "KnowledgePulseServer-5.7.2-final";
        }

        //#Bonsai Snippets - MethodDefinitions

        private void SetButtonControl(string buttonText, string url, LinkButtonControlViewModel model)
        {
            model.ButtonText = buttonText;
            model.URL = url;
        }
    }
}