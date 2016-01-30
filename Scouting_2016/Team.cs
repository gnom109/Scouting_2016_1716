using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scouting_2016
{
    class Team
    {
        private int number;
        private int auto_Points;
        private int tele_Points;
        private int total_Points;

        private int auto_Approached;
        private int auto_Crossed;
        private int auto_HighGoals;
        private int auto_LowGoals;
        private int tele_Crossed;
        private int tele_LowGoals;
        private int tele_HighGoals;

        private int powerRating;

        private bool towerChallenged;
        private bool towerScaled;

        public Team(int number)
        {
            setNumber(number);
        }
        public void setNumber(int num)
        {
            number = num;
        }

        public void setautoPoints(int num)
        {
            auto_Points = num;
        }

        public void settelePoints(int num)
        {
            tele_Points = num;
        }

        public void settotalPoints(int num)
        {
            total_Points = num;
        }

        public int getautoPoints()
        {
            return auto_Points;
        }

        public int gettelePoints()
        {
            return tele_Points;
        }

        public int getNumber()
        {
            return number;
        }

        public int getTotal()
        {
            return total_Points;
        }
        public void setAutoApproached(int num)
        {
            auto_Approached = num;
        }

        public void setAutoCrossed(int num)
        {
            auto_Crossed = num;
        }

        public void setAutoHighGoals(int num)
        {
            auto_HighGoals = num;
        }

        public void setAutoLowGoals(int num)
        {
            auto_LowGoals = num;
        }

        public void setteleCrossed(int num)
        {
            tele_Crossed = num;
        }

        public void setteleLowGoals(int num)
        {
            tele_LowGoals = num;
        }

        public void setteleHighGoals(int num)
        {
            tele_HighGoals = num;
        }

        public void setTowerChallenged(bool a)
        {
            towerChallenged = a;
        }

        public void setTowerScaled(bool a)
        {
            towerScaled = a;
        }

        public int getAutoApproached()
        {
            return auto_Approached;
        }

        public int getAutoCrossed()
        {
            return auto_Crossed;
        }

        public int getAutoHighGoals()
        {
            return auto_HighGoals;
        }

        public int getAutoLowGoals()
        {
            return auto_LowGoals;
        }

        public int getteleCrossed()
        {
            return tele_Crossed;
        }

        public int getteleHighGoals()
        {
            return tele_HighGoals;
        }

        public int getteleLowGoals()
        {
            return tele_LowGoals;
        }

        public bool istowerChallenged()
        {
            return towerChallenged;
        }
        public bool istowerScaled()
        {
            return towerScaled;
        }





        public void sumPoints()
        {
            total_Points = getautoPoints() + gettelePoints();
            

        }




    }
}
