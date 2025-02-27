using System;
using System.Collections.Generic;
using System.Diagnostics;
using Acr.UserDialogs;
using BaseBonsai.DataContracts;
using BaseBonsai.Networking;
using Newtonsoft.Json;
using RekindleLearing.Interface.Repository;
using RekindleLearing.Root.ViewModel;
using RekindleLearing.Trunk.Repository.Implementation;
using Xamarin.Forms;

namespace RekindleLearing.Root.ViewController
{
    public abstract class ProjectBaseViewController<T> : BaseViewController<T>
        where T : ProjectBaseViewModel
    {
        public IMasterRepository _MasterRepo { get; set; }
        protected List<ValidationRule> BrokenRules;
        public bool HasSpecificResponse { get; set; }

        protected ProjectBaseViewController()
            :base(new RestService(DependencyService.Get<INetworkInteraction>()),
            "587682495",
            "RekindleLearing"
            , "NYDAlySr6I+neL8hNPp1uejOMs2KPywXnPCMWQMqgqgMsd5bTRhEI5qwUgv2w8OzE3ffOvCOL68=")
        {
            _MasterRepo = MasterRepository.MasterRepo;

            HasSpecificResponse = false;
            BrokenRules = new List<ValidationRule>();
            base.NetworkInteractionSucceeded += (sender, e) =>
            {
                base._RawBytes = e.RawBytes;
                base._ResponseContent = e.NetworkResponseContent;
            };

            base.NetworkInteractionFailed += (sender, e) =>
            {
                string mys = e.NetworkCallMessage;
                UserDialogs.Instance.Toast(new ToastConfig(e.NetworkCallMessage).SetDuration(TimeSpan.FromSeconds(5)).SetBackgroundColor(System.Drawing.Color.FromArgb(193, 57, 43)));
            };
            base.NetworkCallInitialised += (sender, e) =>
            {
                UserDialogs.Instance.ShowLoading();
            };
            base.NetworkCallCompleted += (sender, e) =>
            {
                UserDialogs.Instance.HideLoading();
            };
        }

        /// <summary>
        /// Serializes the object.
        /// </summary>
        /// <param name="objectToSerialize">The object to serialize.</param>
        /// <returns></returns>
        protected override string SerializeObject(T objectToSerialize)
        {
            return JsonConvert.SerializeObject(objectToSerialize);
        }

        /// <summary>
        /// Serializes the type of the object with.
        /// </summary>
        /// <typeparam name="G"></typeparam>
        /// <param name="objectToSerialize">The object to serialize.</param>
        /// <returns></returns>
        public string SerializeObjectWithType<G>(G objectToSerialize)
        {
            return JsonConvert.SerializeObject(objectToSerialize);
        }

        /// <summary>
        /// Deserializes the object.
        /// </summary>
        /// <typeparam name="G"></typeparam>
        /// <param name="stringToDeserialize">The string to deserialize.</param>
        /// <returns></returns>
        protected G DeserializeObject<G>(string stringToDeserialize)
        {
            var returnObject = JsonConvert.DeserializeObject<G>(stringToDeserialize);
            Debug.WriteLine(stringToDeserialize);
            return returnObject;
        }

        /// <summary>
        /// Shows the message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void ShowMessage(string message)
        {
            try
            {
                var toastOptions = new ToastConfig(message);
                toastOptions.SetDuration(TimeSpan.FromSeconds(5));
                toastOptions.SetBackgroundColor(System.Drawing.Color.Red);
                toastOptions.SetPosition(ToastPosition.Bottom);
                toastOptions.SetMessageTextColor(System.Drawing.Color.White);

                UserDialogs.Instance.Toast(message, TimeSpan.FromSeconds(5));

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void ShowError(string message)
        {
            try
            {
                var toastOptions = new ToastConfig(message);
                toastOptions.SetDuration(TimeSpan.FromSeconds(5));
                toastOptions.SetBackgroundColor(System.Drawing.Color.Red);
                toastOptions.SetPosition(ToastPosition.Bottom);
                toastOptions.SetMessageTextColor(System.Drawing.Color.White);

                UserDialogs.Instance.Toast(toastOptions);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Validates the broken rules.
        /// </summary>
        /// <returns></returns>
        protected string ValidateBrokenRules()
        {
            foreach (ValidationRule check in this.BrokenRules)
            {
                if (!check.Check())
                    return check.ErrorMessage;
            }

            return "";
        }

        public abstract void SetRepositories();

        /// <summary>
        /// Sets the service network online.
        /// </summary>
        protected virtual void SetServiceNetworkOnline()
        {
        }

        /// <summary>
        /// Sets the service network offline.
        /// </summary>
        protected virtual void SetServiceNetworkOffline()
        {
        }

        private void SetServiceNetworkAccess(bool isConnected)
        {
            if (isConnected)
                SetServiceNetworkOnline();
            else
                SetServiceNetworkOffline();
        }
    }
}

