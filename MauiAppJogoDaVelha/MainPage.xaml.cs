namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
       
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object? sender, EventArgs e)
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

            // Jogador "X"
            // Horizontal:
            if ((btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") ||
                (btn13.Text == "X" && btn14.Text == "X" && btn15.Text == "X") ||
                (btn16.Text == "X" && btn17.Text == "X" && btn18.Text == "X") ||
             // Vertical:
                (btn10.Text == "X" && btn13.Text == "X" && btn16.Text == "X") ||
                (btn11.Text == "X" && btn14.Text == "X" && btn17.Text == "X") ||
                (btn12.Text == "X" && btn15.Text == "X" && btn18.Text == "X") ||
            // Diagonal:
                (btn10.Text == "X" && btn14.Text == "X" && btn18.Text == "X") ||
                (btn12.Text == "X" && btn14.Text == "X" && btn16.Text == "X"))
            {
                await DisplayAlertAsync("Parabéns!!!", "O jogador X venceu!!", "OK");
                Zerar();
                return;
            }

            // Jogador "0"
            // Horizontal:
            if ((btn10.Text == "0" && btn11.Text == "0" && btn12.Text == "0") ||
                (btn13.Text == "0" && btn14.Text == "0" && btn15.Text == "0") ||
                (btn16.Text == "0" && btn17.Text == "0" && btn18.Text == "0") ||
                // Vertical:
                (btn10.Text == "0" && btn13.Text == "0" && btn16.Text == "0") ||
                (btn11.Text == "0" && btn14.Text == "0" && btn17.Text == "0") ||
                (btn12.Text == "0" && btn15.Text == "0" && btn18.Text == "0") ||
            // Diagonal:
                (btn10.Text == "0" && btn14.Text == "0" && btn18.Text == "0") ||
                (btn12.Text == "0" && btn14.Text == "0" && btn16.Text == "0"))
            {
                await DisplayAlertAsync("Parabéns!!!", "O jogador 0 venceu!!", "OK");
                Zerar();
                return;

            }

            // Empate "Deu Velha"
            if (!btn10.IsEnabled && !btn11.IsEnabled && !btn12.IsEnabled &&
            !btn13.IsEnabled && !btn14.IsEnabled && !btn15.IsEnabled &&
            !btn16.IsEnabled && !btn17.IsEnabled && !btn18.IsEnabled)
            {
                await DisplayAlertAsync("Fim de Jogo", "Deu velha!", "OK");
                Zerar();
                return;
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
