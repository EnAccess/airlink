﻿using Airlink.Views;
using Airlink.Views.Profile;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Airlink.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class ProfilePageViewModel : ContentPage
    {
        public ICommand DevicesCommand { get; }
        public ICommand APIsCommand { get; }
        public ICommand SettingCommand { get; }

        public Command<string> LogoutCommand { get; }

        public Command<string> ProfileCommand { get; }
        public ProfilePageViewModel()
        {
            DevicesCommand = new Command(DevicesPageCommand);
            //APIsCommand = new Command(APIsPageCommand);
            //SettingCommand = new Command(SettingPageCommand);
            //LogoutCommand = new Command<string>(LogoutPageCommand);

        }

        //private async void LogoutPageCommand(string id)
        //{
        //    
        //}

        /*private async void SettingPageCommand()
        {
            await Shell.Current.GoToAsync(nameof(SettingPage));
        }

        private async void APIsPageCommand()
        {
            var route = $"{nameof(APIsPage)}";
            await Shell.Current.GoToAsync(route);
        }*/

        public async void DevicesPageCommand()
        {
            var route = $"{nameof(DevicePage)}";
            await Shell.Current.GoToAsync(route);
        }

    }
}
