using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickbaitGenerator
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        String game;
        String somethingThatHappened;
        String location;
        String somethingThatHappenedVlogs;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameInput_TextChanged(object sender, EventArgs e)
        {
            game = gameInput.Text.ToUpper();
        }

        private void somethingThatHappenedInput_TextChanged(object sender, EventArgs e)
        {
            somethingThatHappened = somethingThatHappenedInput.Text.ToUpper();
        }

        private void locationInput_TextChanged(object sender, EventArgs e)
        {
            location = locationInput.Text.ToUpper();
        }

        private void somethingThatHappenedVlogsInput_TextChanged(object sender, EventArgs e)
        {
            somethingThatHappenedVlogs = somethingThatHappenedVlogsInput.Text.ToUpper();
        }

        private void generateGamingButton_Click(object sender, EventArgs e)
        {
            var randomNumber = rand.Next(0, 43);
            switch (randomNumber)
            {
                case 0:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " IN " + game + "!? (INSANE)";
                    break;
                case 1:
                    generatedGamingTitle.Text = "LEAKED NEW UPDATE COMING TO " + game + "!? (TOP SECRET)";
                    break;
                case 2:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " AND YOU WILL NOT BELIEVE WHAT HAPPENED... (GONE WRONG)";
                    break;
                case 3:
                    generatedGamingTitle.Text = "BRAND NEW DATAMINE FOR " + game + " REVEALS DARK SECRET!? (I " + somethingThatHappened + ")";
                    break;
                case 4:
                    generatedGamingTitle.Text = "TOP " + rand.Next(1, 16) + " FACTS YOU DIDNT KNOW ABOUT " + game + "!! (NUMBER " + rand.Next(2, 15) + " WILL SHOCK YOU)";
                    break;
                case 5:
                    generatedGamingTitle.Text = "IF I " + somethingThatHappened + " I LOSE $" + rand.Next(1, 11) + "0,000... (" + game + " CHALLENGE)";
                    break;
                case 6:
                    generatedGamingTitle.Text = "YOU WONT BELIEVE THAT I " + somethingThatHappened + " IN THE HIDDEN LEVEL OF " + game + "!?";
                    break;
                case 7:
                    generatedGamingTitle.Text = "NEW HIDDEN SECRET DISCOVERED IN " + game + "!?";
                    break;
                case 8:
                    generatedGamingTitle.Text = "YOU WONT BELIEVE THAT I " + somethingThatHappened + " AND UNLOCKED THIS IN " + game + "...";
                    break;
                case 9:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " FOR GOD MODE IN " + game + "!?";
                    break;
                case 10:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " AND LEAKED THE NEXT " + game + " FIGHTER!?";
                    break;
                case 11:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " IN " + game + " AT 3 AM!? (YOU WONT BELIEVE WHAT HAPPENED)";
                    break;
                case 12:
                    generatedGamingTitle.Text = "WE FOUND SOMETHING IN " + game + " AND YOU WONT BELIEVE WHAT HAPPENED...";
                    break;
                case 13:
                    generatedGamingTitle.Text = "WE FOUND A SECRET IN " + game + " AND YOU WONT BELIEVE WHAT HAPPENED...";
                    break;
                case 14:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " IN " + game + " AND IT DID WHAT!? (SCARY)";
                    break;
                case 15:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " IN " + game + " AND UNLOCKED WHAT!? (OMG)";
                    break;
                case 16:
                    generatedGamingTitle.Text = "TWITCH BANNED ME WHEN I " + somethingThatHappened + " IN " + game + "...";
                    break;
                case 17:
                    generatedGamingTitle.Text = "SOMETHING HAPPENED WHEN I " + somethingThatHappened + " IN " + game + "...";
                    break;
                case 18:
                    generatedGamingTitle.Text = "YOUTUBE WONT RECCOMEND THIS BECAUSE I " + somethingThatHappened + " IN " + game + "!?";
                    break;
                case 19:
                    generatedGamingTitle.Text = "HOW TO GET MILLIONS OF COINS IN " + game + "!? (LEGIT FREE 100% WORKING)";
                    break;
                case 20:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " IN " + game + " AND UNLOCKED THE SECRET MINIGAME!?";
                    break;
                case 21:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " IN " + game + " AND IT DID WHAT TO MY PC!?";
                    break;
                case 22:
                    generatedGamingTitle.Text = "MY " + game + " ACCOUNT GOT HACKED WHEN I " + somethingThatHappened + "...";
                    break;
                case 23:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " IN " + game + " AT 3AM AND THIS HAPPENED... (MUST WATCH)";
                    break;
                case 24:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " IN " + game + "!? (CRAZY)";
                    break;
                case 25:
                    generatedGamingTitle.Text = "LEAKED NEW DLC COMING TO " + game + "!? (EARLY BUILD)";
                    break;
                case 26:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " AND YOU WILL NOT BELIEVE WHAT HAPPENED... (ULTIMATE CHALLENGE)";
                    break;
                case 27:
                    generatedGamingTitle.Text = "BRAND NEW UPDATE FOR " + game + " REVEALS INSANE SECRET!? (I " + somethingThatHappened + ")";
                    break;
                case 28:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " IN THE HIDDEN LEVEL OF " + game + " AND THIS HAPPENED!?";
                    break;
                case 29:
                    generatedGamingTitle.Text = "NEW HIDDEN UPDATE DISCOVERED IN " + game + "!? (ULTIMATE LEAK)";
                    break;
                case 30:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " FOR ADMIN IN " + game + "!?";
                    break;
                case 31:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " IN " + game + " AT 3 AM!? (SUPER SCARY...)";
                    break;
                case 32:
                    generatedGamingTitle.Text = "WE FOUND A SECRET ENDING IN " + game + " AND IT WAS INSANE...";
                    break;
                case 33:
                    generatedGamingTitle.Text = "WE FOUND A GAME BREAKING BUG IN " + game + " AND IT HACKED MY ACCOUNT!";
                    break;
                case 34:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " IN " + game + " AND IT DID THIS... (SO SPOOKY)";
                    break;
                case 35:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " IN " + game + " AND UNLOCKED A SECRET ENDING!? (MUST WATCH)";
                    break;
                case 36:
                    generatedGamingTitle.Text = "YOUTUBE BANNED ME WHEN I " + somethingThatHappened + " IN " + game + "...";
                    break;
                case 37:
                    generatedGamingTitle.Text = "SOMETHING INSANE HAPPENED WHEN I " + somethingThatHappened + " IN " + game + "...";
                    break;
                case 38:
                    generatedGamingTitle.Text = "YOUTUBE WONT LET YOU SEE THIS VIDEO BECAUSE I " + somethingThatHappened + " IN " + game + "!? (DEMONITIZED)";
                    break;
                case 39:
                    generatedGamingTitle.Text = "HOW TO GET UNLIMITED CASH IN " + game + "!? (UPDATED " + DateTime.Now.Year + ")";
                    break;
                case 40:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " IN " + game + " AND UNLOCKED THE SECRET LEVEL!?";
                    break;
                case 41:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " IN " + game + " AND IT LET HACKERS INTO MY PC!?";
                    break;
                case 42:
                    generatedGamingTitle.Text = "I " + somethingThatHappened + " IN " + game + " AT 3AM AND THIS HAPPENED... (GONE WRONG)";
                    break;
            }
        }

        private void generateVlogsButton_Click(object sender, EventArgs e)
        {
            var randomNumber = rand.Next(0, 21);
            switch (randomNumber)
            {
                case 0:
                    generateVlogsTitle.Text = "DONT WATCH THIS VIDEO AROUND YOUR PARENTS...";
                    break;
                case 1:
                    generateVlogsTitle.Text = "YOU WONT BELIEVE WHAT WE DID...";
                    break;
                case 2:
                    generateVlogsTitle.Text = somethingThatHappenedVlogs + " PRANK (IN THE SHOWER)";
                    break;
                case 3:
                    generateVlogsTitle.Text = somethingThatHappenedVlogs + " PRANK (IN THE HOOD)";
                    break;
                case 4:
                    generateVlogsTitle.Text = "HERES WHY I " + somethingThatHappenedVlogs + "...";
                    break;
                case 5:
                    generateVlogsTitle.Text = "WTF... WE SHOULD NOT HAVE " + somethingThatHappenedVlogs + "...";
                    break;
                case 6:
                    generateVlogsTitle.Text = "I " + somethingThatHappenedVlogs + " - HOT GIRLFRIEND PRANK! (GONE SEXUAL)";
                    break;
                case 7:
                    generateVlogsTitle.Text = "THE WORST PAIN I HAVE EVER FELT...";
                    break;
                case 8:
                    generateVlogsTitle.Text = "INSANE " + somethingThatHappenedVlogs + " CHALLENGE! (I DIED)";
                    break;
                case 9:
                    generateVlogsTitle.Text = "INSANE " + somethingThatHappenedVlogs + " CHALLENGE! (AT 3 AM)";
                    break;
                case 10:
                    generateVlogsTitle.Text = "HOW I " + somethingThatHappenedVlogs + "!? (INSANE STORY)";
                    break;
                case 11:
                    generateVlogsTitle.Text = "YOU WONT BELIEVE THAT I ACTUALLY DID THIS... (" + somethingThatHappenedVlogs + ")";
                    break;
                case 12:
                    generateVlogsTitle.Text = somethingThatHappenedVlogs + " IN " + location + "!? (CRAZY TRIP)";
                    break;
                case 13:
                    generateVlogsTitle.Text = "TAKING A TRIP TO " + location + " (I " + somethingThatHappenedVlogs + "?!)";
                    break;
                case 14:
                    generateVlogsTitle.Text = "HOT GIRLFRIEND " + somethingThatHappenedVlogs + "!? (GRAPHIC)";
                    break;
                case 15:
                    generateVlogsTitle.Text = "I " + somethingThatHappenedVlogs + " WITH MY GIRLFRIEND... (NOT SAFE FOR YOUTUBE)";
                    break;
                case 16:
                    generateVlogsTitle.Text = somethingThatHappenedVlogs + " AT THE BAR CHALLENGE! (PICKED UP A GIRL)";
                    break;
                case 17:
                    generateVlogsTitle.Text = somethingThatHappenedVlogs + " WITH NO CLOTHES ON!? (NSFW)";
                    break;
                case 18:
                    generateVlogsTitle.Text = somethingThatHappenedVlogs + " WITH NO CLOTHES ON IN " + location + "!? (MUST SEE)";
                    break;
                case 19:
                    generateVlogsTitle.Text = somethingThatHappenedVlogs + " FOR 24 HOURS CHALLENGE?!";
                    break;
                case 20:
                    generateVlogsTitle.Text = "I ALMOST DIED WHEN I " + somethingThatHappenedVlogs + "...";
                    break;
            }
        }
    }
}
