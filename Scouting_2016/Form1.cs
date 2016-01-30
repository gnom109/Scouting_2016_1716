using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scouting_2016
{
    public partial class Scouting_2016 : Form
    {
        List<Team> TeamList = new List<Team>();
        int teamProgress;
       public StreamWriter writer = new StreamWriter("scores.txt");

        public Scouting_2016()
        {
            InitializeComponent();
            teamProgress = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void input_Button_Click(object sender, EventArgs e)
        {
            
            int teamNumber = Int32.Parse(team_Number_Box.Text);
            TeamList.Add(new Team(teamNumber));
            int approached, crossed, low_Goals, high_Goals, auto_Total, crossed_Tele, low_Goals_Tele, high_Goals_Tele, tele_Total, Total = 0;
           

            approached = Int32.Parse(approached_Box.Text) * 2;
            TeamList[teamProgress].setAutoApproached(approached/2);

            crossed = Int32.Parse(crossed_Box.Text) * 10;
            TeamList[teamProgress].setAutoCrossed(crossed / 10);

            low_Goals = Int32.Parse(low_Goals_Box.Text) * 5;
            TeamList[teamProgress].setAutoLowGoals(low_Goals / 5);

            high_Goals = Int32.Parse(high_Goals_Box.Text) * 10;
            TeamList[teamProgress].setAutoHighGoals(high_Goals / 10);

            auto_Total = approached + crossed + low_Goals + high_Goals;

            crossed_Tele = Int32.Parse(crossing_Tele_Box.Text) * 5;
            TeamList[teamProgress].setteleCrossed(crossed_Tele / 5);

            low_Goals_Tele = Int32.Parse(low_Goals_Tele_Box.Text) * 2;
            TeamList[teamProgress].setAutoLowGoals(low_Goals_Tele / 2);

            high_Goals_Tele = Int32.Parse(high_Goals_Tele_Box.Text) * 5;
            TeamList[teamProgress].setteleHighGoals(high_Goals_Tele / 5);

            tele_Total = crossed_Tele + low_Goals_Tele + high_Goals_Tele;

   
            if(challenged_Tower_Tele_Box.Checked == true)
            {
                tele_Total += 5;
                TeamList[teamProgress].setTowerChallenged(true);

            }
            if (scaling_Tower_Tele_Box.Checked == true)
            {
                tele_Total += 15;
                TeamList[teamProgress].setTowerScaled(true);

            }

            Total = auto_Total + tele_Total;

            TeamList[teamProgress].setautoPoints(auto_Total);
            TeamList[teamProgress].settelePoints(tele_Total);
            TeamList[teamProgress].settotalPoints(Total);

            output_Label.Text = Total.ToString();
            // printScores();
            //  writer.WriteLine("Anus");

            //using (StreamWriter writer = new StreamWriter("scores.txt"))
            //{
            //    String teamOutput = team_Number_Box.ToString();
            //    writer.WriteLine("Team Number:" + TeamList[teamProgress].getNumber().ToString());
            //    writer.WriteLine("Auto Score:" + TeamList[teamProgress].getautoPoints().ToString());
            //    writer.WriteLine("Tele Score:" + TeamList[teamProgress].gettelePoints().ToString());
            //    writer.WriteLine("Total Score:" + TeamList[teamProgress].getTotal().ToString());
            //    //writer.WriteLine("Team Number:"+teamNumber.ToString());
            //    //writer.WriteLine("Auto Score:"+auto_Total.ToString());
            //    //writer.WriteLine("Tele Score:"+tele_Total.ToString());
            //    //writer.WriteLine("Total Score:"+Total.ToString());
            //}
            teamProgress++;
           int labelTeam = teamProgress - 1;

            team_Progress_Label.Text = "# of teams inputted: "+labelTeam.ToString();

        }

        private void Scouting_2016_Load(object sender, EventArgs e)
        {

        }

        public void printScores()
        {
           using (writer)
            {
                for (int i = 0; i < teamProgress - 1;)
               {
                    //String teamOutput = team_Number_Box.ToString();
                    //writer.WriteLine("Team Number:" + TeamList[i].getNumber().ToString());
                    //writer.WriteLine("Auto Score:" + TeamList[i].getautoPoints().ToString());
                    //writer.WriteLine("Tele Score:" + TeamList[i].gettelePoints().ToString());
                    //writer.WriteLine("Total Score:" + TeamList[i].getTotal().ToString());

            writer.WriteLine("Team Number:" + TeamList[i].getNumber().ToString());
            writer.WriteLine("Auto Score:" + TeamList[i].getautoPoints().ToString());
            writer.WriteLine("Tele Score:" + TeamList[i].gettelePoints().ToString());
            writer.WriteLine("Total Score:" + TeamList[i].getTotal().ToString());
            writer.WriteLine("Auto Points");
            writer.WriteLine("-----------");

            writer.WriteLine("Approached:" + TeamList[i].getAutoApproached().ToString());
            writer.WriteLine("Crossed:" + TeamList[i].getAutoApproached().ToString());
            writer.WriteLine("Low Goals:" + TeamList[i].getAutoLowGoals().ToString());
            writer.WriteLine("High Goals:" + TeamList[i].getAutoHighGoals().ToString());

            writer.WriteLine("Tele Points:");
            writer.WriteLine("------------");

            writer.WriteLine("Crossed:" + TeamList[i].getteleCrossed().ToString());
            writer.WriteLine("Low Goals:" + TeamList[i].getteleLowGoals().ToString());
            writer.WriteLine("High Goals:" + TeamList[i].getteleHighGoals().ToString());
            writer.WriteLine("Challenged Tower:" + TeamList[i].istowerChallenged().ToString());
            writer.WriteLine("Scaled Tower:" + TeamList[i].istowerScaled().ToString());










                    writer.WriteLine(" ");
                    writer.WriteLine(" ");

                    i++;
             }
            //writer.WriteLine("Team Number:"+teamNumber.ToString());
            //writer.WriteLine("Auto Score:"+auto_Total.ToString());
            //writer.WriteLine("Tele Score:"+tele_Total.ToString());
            //writer.WriteLine("Total Score:"+Total.ToString());
             }
            score_Print_Button.Visible = false;
            scores_Printed_Label.Text = "Scores Printed, check project folder";
        }

        private void score_Print_Button_Click(object sender, EventArgs e)
        {

            printScores();
        }
    }

}
