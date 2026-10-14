namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
       
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "0";
            } else
            {
                btn.Text = "0";
                vez = "X";
            }
            
            if(btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                await DisplayAlertAsync("Parabéns!!!", "O jogador X venceu!!", "OK");
            }

        }
        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn14.Text = "";
            btn15.Text = "";
            btn16.Text = "";
            btn17.Text = "";
            btn18.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn13.IsEnabled = true;
            btn14.IsEnabled = true;
            btn15.IsEnabled = true;
            btn16.IsEnabled = true;
            btn17.IsEnabled = true;
            btn18.IsEnabled = true;
        }   
    }
}
