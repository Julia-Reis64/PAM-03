namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {

        int sorteio = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void FlipButton_Clicked(object sender, EventArgs e)
        {
            //Algoritmo
            //Verificar qual opção selecionada (if alguma coisa)
            //Fazer o sorteio da moeda (Random, 1 e 2)
            //Exibir o lado que foi sorteado (Image.Source = "-.png")
            //Verificar se a opção é igual o lado (if)
            //Exibir o resultado do jogo em um alerta (DisplayAlert)


            Random random = new Random();
            int Sorteio = random.Next(2);

            if (Sorteio == 0){
                MoedaImagem.Source = "cara.png";
            }
            else{
                Sorteio = 1;
                MoedaImagem.Source = "coroa.png";
            }
            
        }

        public async void ExibirAlerta(int Sorteio){
            if (FlipCoin.SelectedIndex == Sorteio){
                await DisplayAlert("Parabéns", "você venceu!", "Ok!");
            }
            else{
               await DisplayAlert("Perdeste!", "poxa vida", "Ok!");
            }
        }
    }

}
