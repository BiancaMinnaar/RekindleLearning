using System.ComponentModel;
using RekindleLearing.Root.ViewModel;
using RekindleLearing.Trunk.ViewModel.Control;

namespace RekindleLearing.Trunk.ViewModel
{
    public class SystemViewModel : ProjectBaseViewModel, INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;


private LinkButtonControlViewModel imprintLinkButton;
        public LinkButtonControlViewModel ImprintLinkButton
        {
            get { return imprintLinkButton; }
            set
            {
                imprintLinkButton = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ImprintLinkButton"));
            }
        }
private LinkButtonControlViewModel termsAndConditonsLinkButton;
        public LinkButtonControlViewModel TermsAndConditonsLinkButton
        {
            get { return termsAndConditonsLinkButton; }
            set
            {
                termsAndConditonsLinkButton = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TermsAndConditonsLinkButton"));
            }
        }
private LinkButtonControlViewModel privacyPolicyLinkButton;
        public LinkButtonControlViewModel PrivacyPolicyLinkButton
        {
            get { return privacyPolicyLinkButton; }
            set
            {
                privacyPolicyLinkButton = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PrivacyPolicyLinkButton"));
            }
        }
private LinkButtonControlViewModel eULALinkButton;
        public LinkButtonControlViewModel EULALinkButton
        {
            get { return eULALinkButton; }
            set
            {
                eULALinkButton = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("EULALinkButton"));
            }
        }
private ServerInfoControlViewModel serverInfoTile;
        public ServerInfoControlViewModel ServerInfoTile
        {
            get { return serverInfoTile; }
            set
            {
                serverInfoTile = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ServerInfoTile"));
            }
        }
private ClientInfoControlViewModel clientInfoTile;
        public ClientInfoControlViewModel ClientInfoTile
        {
            get { return clientInfoTile; }
            set
            {
                clientInfoTile = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ClientInfoTile"));
            }
        }

        public SystemViewModel()
        {
            ImprintLinkButton = new LinkButtonControlViewModel();
            TermsAndConditonsLinkButton = new LinkButtonControlViewModel();
            PrivacyPolicyLinkButton = new LinkButtonControlViewModel();
            EULALinkButton = new LinkButtonControlViewModel();
            ServerInfoTile = new ServerInfoControlViewModel();
            ClientInfoTile = new ClientInfoControlViewModel();
        }
 //#Bonsai Snippets - Properties
    }
}