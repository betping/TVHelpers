using Windows.ApplicationModel;

namespace MediaAppSample.Core.ViewModels
{
    public partial class AboutViewModel : ViewModelBase
    {
        #region Properties

        /// <summary>
        /// Gets the title to be displayed on the view consuming this ViewModel.
        /// </summary>
        public override string Title
        {
            get { return Strings.Resources.ViewTitleAbout; }
        }

        public string TwitterAddress { get { return Strings.Resources.ApplicationSupportTwitterUsername; } }

        #endregion

        #region Constructors

        public AboutViewModel()
        {
            if (DesignMode.DesignModeEnabled)
                return;
        }

        #endregion
    }

    public partial class AboutViewModel
    {
        /// <summary>
        /// Self-reference back to this ViewModel. Used for designtime datacontext on pages to reference itself with the same "ViewModel" accessor used 
        /// by x:Bind and it's ViewModel property accessor on the View class. This allows you to do find-replace on views for 'Binding' to 'x:Bind'.
        [Newtonsoft.Json.JsonIgnore()]
        [System.Runtime.Serialization.IgnoreDataMember()]
        public AboutViewModel ViewModel { get { return this; } }
    }
}

namespace MediaAppSample.Core.ViewModels.Designer
{
    public sealed class AboutViewModel : MediaAppSample.Core.ViewModels.AboutViewModel
    {
        public AboutViewModel()
        {
        }
    }
}