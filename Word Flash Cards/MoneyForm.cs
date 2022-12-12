using System;
using System.Windows.Forms;

namespace Word_Flash_Cards
{
    public partial class MoneyForm : Form
    {
        public MoneyForm()
        {
            InitializeComponent();
        }

        bool AdditionOperator = false;
        bool SubtractionOperator = false;

        decimal Total = 0;
        decimal CalculateDollar = 0;
        decimal CalculateCoin = 0;

        Choice PlayerChoice;

        public enum Choice
        {
            ADD,
            SUBTRACT,
            NONE
        }

        //Coins
        const decimal PENNY = .01m;
        const decimal NICKEL = .05m;
        const decimal DIME = .10m;
        const decimal QUARTER = .25m;

        //Dollars bills
        const decimal ONEDOLLAR = 1.00m;
        const decimal TWODOLLAR = 2.00m;
        const decimal FIVEDOLLAR = 5.00m;
        const decimal TENDOLLAR = 10m;
        const decimal TWENTYDOLLAR = 20m;
        const decimal FIFTYDOLLAR = 50m;
        const decimal ONEHUNDREDDOLLAR = 100m;

        //Tally Counts
        int PenniesCount;
        int NikelsCount;
        int DimesCount;
        int QuartersCount;

        int Dollar1Count;
        int Dollar2Count;
        int Dollart5Count;
        int Dollar10Count;
        int Dollar20Count;
        int Dollar50Count;
        int Dollar100Count;


        private void Money_Load(object sender, EventArgs e)
        {
        }

        //private decimal Coin_Click(object sender, EventArgs e, decimal CalculateCoin)
        //{
        //    Button[] CoinButtons = new Button[4];
        //    decimal[] CoinValue = new decimal[4];

        //    CoinValue[0] = PENNY;
        //    CoinValue[1] = NICKLE;
        //    CoinValue[2] = DIME;
        //    CoinValue[3] = QUARTER;

        //    CoinButtons[0] = btnPenny;
        //    CoinButtons[1] = btnNickel;
        //    CoinButtons[2] = btnDime;
        //    CoinButtons[3] = btnQuarter;

        //    Button CoinSelection = (Button)sender;

        //    if (CoinSelection == CoinButtons[0])
        //    {
        //        CalculateCoin = CoinValue[0];
        //    }
        //    else if (CoinSelection == CoinButtons[1])
        //    {
        //        CalculateCoin  = CoinValue[1];
        //    }
        //    else if (CoinSelection == CoinButtons[2])
        //    {
        //        CalculateCoin = CoinValue[2];
        //    }
        //    else if (CoinSelection == CoinButtons[3])
        //    {
        //        CalculateCoin = CoinValue[3];
        //    }
        //    return Total;
        //}

        //private decimal Dollar_Click(object sender, EventArgs e)
        //{
        //    decimal[] DollarValues = new decimal[7];
        //    Button[] DollarButtons = new Button[7];
        //    Button DollarSelection = (Button)sender;

        //    DollarValues[0] = ONEDOLLAR;
        //    DollarValues[1] = TWODOLLAR;
        //    DollarValues[2] = FIVEDOLLAR;
        //    DollarValues[3] = TENDOLLAR;
        //    DollarValues[4] = TWENTYDOLLAR;
        //    DollarValues[5] = FIFTYDOLLAR;
        //    DollarValues[6] = ONEHUNDREDDOLLAR;

        //    DollarButtons[0] = btn1Dollar;
        //    DollarButtons[1] = btn2Dollar;
        //    DollarButtons[2] = btn5Dollar;
        //    DollarButtons[3] = btn10Dollar;
        //    DollarButtons[4] = btn20Dollar;
        //    DollarButtons[5] = btn50Dollar;
        //    DollarButtons[6] = btn100Dollar;

        //    if (DollarSelection == DollarButtons[0])
        //    {
        //        CalculateDollar = DollarValues[0];
        //    }
        //    else if (DollarSelection == DollarButtons[1])
        //    {
        //        CalculateDollar = DollarValues[1];
        //    }
        //    else if (DollarSelection == DollarButtons[2])
        //    {
        //        CalculateDollar = DollarValues[2];
        //    }
        //    else if (DollarSelection == DollarButtons[3])
        //    {
        //        CalculateDollar = DollarValues[3];
        //    }
        //    else if (DollarSelection == DollarButtons[4])
        //    {
        //        CalculateDollar = DollarValues[4];
        //    }
        //    else if (DollarSelection == DollarButtons[5])
        //    {
        //        CalculateDollar = DollarValues[5];
        //    }
        //    else if (DollarSelection == DollarButtons[6])
        //    {
        //        CalculateDollar = DollarValues[6];
        //    }


        //    return Total;
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //lblBalance.Text = Total.ToString("c2");
            //PlayerChoice = Choice.ADD;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            /////Need to figure out
            //lblBalance.Text = Total.ToString("c2");
            //PlayerChoice = Choice.SUBTRACT;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Total = 0;
            lblBalance.Text = Total.ToString("c2");
            TallyBox.Items.Clear();
            PenniesCount = 0;
            NikelsCount = 0;
            DimesCount = 0;
            QuartersCount = 0;

            Dollar1Count = 0;
            Dollar2Count = 0;
            Dollart5Count = 0;
            Dollar10Count = 0;
            Dollar20Count = 0;
            Dollar50Count = 0;
            Dollar100Count = 0;
        }

        private void TallyCounter()
        {
            TallyBox.Items.Clear();
            TallyBox.Items.Add(PenniesCount.ToString() + " :Pennies");
            TallyBox.Items.Add(NikelsCount.ToString() + " :Nickels");
            TallyBox.Items.Add(DimesCount.ToString() + " :Dimes");
            TallyBox.Items.Add(QuartersCount.ToString() + " :Quarters");
            TallyBox.Items.Add("");
            TallyBox.Items.Add(Dollar1Count.ToString() + " :One Dollars");
            TallyBox.Items.Add(Dollar2Count.ToString() + " :Two Dollars");
            TallyBox.Items.Add(Dollart5Count.ToString() + " :Five Dollars");
            TallyBox.Items.Add(Dollar10Count.ToString() + " :Ten Dollars");
            TallyBox.Items.Add(Dollar20Count.ToString() + " :Twenty Dollars");
            TallyBox.Items.Add(Dollar50Count.ToString() + " :Fifty Dollars");
            TallyBox.Items.Add(Dollar100Count.ToString() + " :One-Hundered Dollars");
        }

        //Coins
        private void btnPenny_Click(object sender, EventArgs e)
        {
            Total += PENNY;
            lblBalance.Text = Total.ToString("c2");

            PenniesCount += 1;
            TallyCounter();
        }

        private void btnNickel_Click(object sender, EventArgs e)
        {
            NikelsCount += 1;
            Total += NICKEL;
            lblBalance.Text = Total.ToString("c2");
            TallyCounter();
        }

        private void btnDime_Click(object sender, EventArgs e)
        {
            DimesCount += 1;
            Total += DIME;
            lblBalance.Text = Total.ToString("c2");
            TallyCounter();
        }

        private void btnQuarter_Click(object sender, EventArgs e)
        {
            QuartersCount += 1;
            Total += QUARTER;
            lblBalance.Text = Total.ToString("c2");
            TallyCounter();
        }

        //Dollars
        private void btn1Dollar_Click(object sender, EventArgs e)
        {
            Dollar1Count += 1;
            Total += ONEDOLLAR;
            lblBalance.Text = Total.ToString("c2");
            TallyCounter();

        }
        private void btn2Dollar_Click(object sender, EventArgs e)
        {
            Dollar2Count += 1;
            Total = +TWODOLLAR;
            lblBalance.Text = Total.ToString("c2");
            TallyCounter();
        }


        private void btn5Dollar_Click(object sender, EventArgs e)
        {
            Dollart5Count += 1;
            Total += FIVEDOLLAR;
            lblBalance.Text = Total.ToString("c2");
            TallyCounter();
        }

        private void btn10Dollar_Click(object sender, EventArgs e)
        {
            Dollar10Count += 1;
            Total += TENDOLLAR;
            lblBalance.Text = Total.ToString("c2");
            TallyCounter();
        }

        private void btn20Dollar_Click(object sender, EventArgs e)
        {
            Dollar20Count += 1;
            Total += TWENTYDOLLAR;
            lblBalance.Text = Total.ToString("c2");
            TallyCounter();
        }

        private void btn50Dollar_Click(object sender, EventArgs e)
        {
            Dollar50Count += 1;
            Total += FIFTYDOLLAR;
            lblBalance.Text = Total.ToString("c2");
            TallyCounter();
        }

        private void btn100Dollar_Click(object sender, EventArgs e)
        {
            Dollar100Count += 1;
            Total += ONEHUNDREDDOLLAR;
            lblBalance.Text = Total.ToString("c2");
            TallyCounter();
        }
    }


}
