using System.Windows;
using WpfDesktop.Services;
using WpfDesktop.Utils;
using WpfDesktop.ViewModels;

namespace WpfDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IMessageService _messageService;

        public MainWindow()
        {
            InitializeComponent();
            _messageService=new MessageService();
        }

        private async void btn_RefreshHttp_Click(object sender, RoutedEventArgs e)
        {
            /* empty the list */
            lst_webmessage.Items.Clear();

            /* call the service method to fetch the updated data from api */
            var messages = await _messageService.GetAllAsync();
            foreach(var message in messages)
            {
                var formatMesg = $"{message.Sender} -> {message.Text}";
                lst_webmessage.Items.Add(formatMesg);
            }
        }

        private async void btn_SendOverHttp_Click(object sender, RoutedEventArgs e)
        {
            /*
             *  get the value from user to pass to service to call the api
             */
            var message = new MessageViewModel { Text = txt_message.Text, Sender = BroadCastSource.desktop.ToString()};

            /* call the service method to post the  data to api */
            var IsSuccess = await _messageService.PostMessage(message);
            if(IsSuccess)
            {
                MessageBox.Show("Made a successfull Http Call !");
            }
           
            }
    }
    
}
