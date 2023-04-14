using System;
using Windows.UI.Xaml.Controls;
using Microsoft.AspNet.SignalR.Client;
using System.ComponentModel;
using Windows.UI.Core;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UwpClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int count = 0;
        public MainPage()
        {
            this.InitializeComponent();
            MessageList = new ObservableCollection<string>();
            InitilizeHub();
        }

        public ObservableCollection<string> MessageList
        {
            get;
            set;
        }

        private async void InitilizeHub()
        {
            var hubConnection = new HubConnection("http://localhost:50869");
            var hubProxy = hubConnection.CreateHubProxy("BroadcastHub");

            hubProxy.On<string>("Broadcast",
                                  async data =>
                                  await Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
                                                                          () =>
                                                                          {
                                                                              count=count+1;
                                                                              BroadcastResults.Text = count.ToString();
                                                                              MessageList.Add(data);
                                                                              //notiifcationList.ItemsSource = messageList;
                                                                          }
                                                                          ));
            await hubConnection.Start();
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void message(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
