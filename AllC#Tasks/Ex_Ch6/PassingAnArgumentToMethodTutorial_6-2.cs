using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllC_Tasks.Ex_Ch6
{
    public partial class PassingAnArgumentToMethodTutorial_6_2 : Form
    {
        public PassingAnArgumentToMethodTutorial_6_2()
        {
            InitializeComponent();
        }
        private void ShowCard(string card)
        {
            switch (card)
            {
                case "Ace of Spades":
                    ShowAceSpades();
                    break;

                case "10 of Hearts":
                    ShowTenHearts();
                    break;

                case "King of Clubs":
                    ShowKingClubs();
                    break;
            }
        }

        // The ShowAceSpades method makes the Ace of Spades visible
        // and hides other cards.
        private void ShowAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }

        // The ShowTenHearts method makes the 10 of Hearts visible
        // and hides other cards.
        private void ShowTenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }

        // The ShowKingClubs method makes the King of Clubs visible
        // and hides other cards.
        private void ShowKingClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }


        private void PassingAnArgumentToMethodTutorial_6_2_Load(object sender, EventArgs e)
        {
            BackColor = AppTheme.BackgroundColor;

            headerPanel.FillColor = AppTheme.HeaderColor;
            titleLabel.ForeColor = AppTheme.HeaderTextColor;

            ShowCardButton.FillColor = AppTheme.PrimaryButtonColor;
            ShowCardButton.ForeColor = Color.White;

            cardListBox.BackColor = AppTheme.TextBoxBackColor;
            cardListBox.ForeColor = AppTheme.TextColor;

            aceSpadesPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            tenHeartsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            kingClubsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void ShowCardButton_Click(object sender, EventArgs e)
        {
            // If a card is selected in the list box, display it.
            if (cardListBox.SelectedIndex != -1 && cardListBox.SelectedItem != null)
            {
                ShowCard(cardListBox.SelectedItem!.ToString()!);
            }
            else
            {
                messageLabel.Text = "Please select a card from the list box.";
            }
        }

       
    }
}
