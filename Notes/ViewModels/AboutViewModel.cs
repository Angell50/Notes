using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Notes.ViewModels
{
    internal class AboutViewModel
    {
        public string Title => AppInfo.Name;
        public string Version => "FELIZ NAVIDAD, JINGLE BELLS, HOHOHO🎄🧑‍🎄🎁 ";
        public string MoreInfoUrl => "https://www.tiktok.com/@andietoktok/video/7449159011057929505?lang=es&q=NAVIDAD%20PROGRAMADORES&t=1734924828361";
        public string Message => "Santi, como deseo de navidad, quiero que todos pasemos el semestre";
        public ICommand ShowMoreInfoCommand { get; }

        public AboutViewModel()
        {
            ShowMoreInfoCommand = new AsyncRelayCommand(ShowMoreInfo);
        }

        async Task ShowMoreInfo() =>
            await Launcher.Default.OpenAsync(MoreInfoUrl);
    }
}
