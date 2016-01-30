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

        public void sumPoints()
        {
            total_Points = getautoPoints() + gettelePoints();
            

        }




    }
}
